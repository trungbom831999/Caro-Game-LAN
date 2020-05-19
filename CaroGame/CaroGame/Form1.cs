using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class Form1 : Form
    {
        #region Properties
        CaroBoardManager CaroBoard;
        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            CaroBoard = new CaroBoardManager(panelCaroBoard, textBoxPlayerName, pictureBoxMark);
            CaroBoard.EndedGame += CaroBoard_EndedGame;
            CaroBoard.Playermarked += CaroBoard_PlayerMarked;

            progressClock.Step = Const.clockStep;
            progressClock.Maximum = Const.clockTime;
            progressClock.Value = 0;

            timerClock.Interval = Const.clockInterval;

            socket = new SocketManager();

            NewGame();
            panelCaroBoard.Enabled = false;
            newGameToolStripMenuItem.Enabled = false;
        }

        #region Methods
        private void CaroBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {            
            timerClock.Start();
            panelCaroBoard.Enabled = false; //sau khi đánh xong sẽ bị vô hiệu hóa bàn cờ
            progressClock.Value = 0;
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, e.ClickedPoint, ""));
            Listen();
        }

        private void CaroBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        void EndGame()
        {
            int check = 0;
            if (CaroBoard.CurrentPlayer == 0) check = 1;
            timerClock.Stop();
            /*if(panelCaroBoard.Enabled == false) MessageBox.Show("You Win");
            if (panelCaroBoard.Enabled == true ) MessageBox.Show("You Lose");*/
            panelCaroBoard.Enabled = false; //khóa bàn cờ
            MessageBox.Show(CaroBoard.Player[check].Name, "Winner");
        }

        void NewGame()
        {
            progressClock.Value = 0;
            timerClock.Stop();
            CaroBoard.drawBoard(); // reset bàn cờ
        }


        void ExitGame()
        {
                Application.Exit();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            progressClock.PerformStep();
            if (progressClock.Value >= progressClock.Maximum)
                EndGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socket.Send(new SocketData((int)SocketCommand.RQ_NEW_GAME, new Point(), ""));
        }


        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitGame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, new Point(), "")); // quit sẽ gửi thông báo cho phía kia
                }
                catch { }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBoxIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211); //địa chỉ wifi
            if (string.IsNullOrEmpty(textBoxIP.Text)) //nếu k kết nối wifi
                textBoxIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet); //lấy địa chỉ mạng
        }

        private void buttonLAN_Click(object sender, EventArgs e)
        {
            socket.IP = textBoxIP.Text; //lấy địa chỉ IP ở textbox
            if (!socket.ConnectServer())
            {                
                socket.isServer = true;
                panelCaroBoard.Enabled = false;
                buttonLAN.Enabled = false;
                buttonPlay.Enabled = true;
                textBoxYourName.Text = CaroBoard.Player[0].Name;
                pictureBoxYourMark.BackgroundImage = CaroBoard.Player[0].Mark;
                socket.CreateServer();
                MessageBox.Show("Nhấn PLAY đến khi tìm được đối thủ", "Hướng dẫn");
            }          
            else
            {
                socket.isServer = false;
                panelCaroBoard.Enabled = false;
                buttonLAN.Enabled = false;
                textBoxYourName.Text = CaroBoard.Player[1].Name;
                pictureBoxYourMark.BackgroundImage = CaroBoard.Player[1].Mark;
                MessageBox.Show("Đã kết nối", "Thông báo");
                socket.Send(new SocketData((int)SocketCommand.START, new Point(), "Đã tìm thấy đối thủ"));
                Listen();                
            }
        }
         
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Listen();
        }

        public void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try //tránh lỗi 1 bên thoát 
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch (Exception e)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
            
        }

        public void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>   
                    {
                        NewGame();                        
                        panelCaroBoard.Enabled = true;                        
                    }));                    
                    if (!socket.isServer)
                    {
                        CaroBoard.CurrentPlayer = 1;
                        CaroBoard.ChangePlayer();
                    }
                    break;
                case (int)SocketCommand.RQ_NEW_GAME:
                    if (MessageBox.Show("Đối thủ muốn chơi ván mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                        socket.Send(MessageBox.Show("Chơi tiếp đi :)))"));
                    else
                    {
                        socket.Send(new SocketData((int)SocketCommand.NEW_GAME, new Point(), ""));
                        this.Invoke((MethodInvoker)(() =>
                        {
                            NewGame();
                            panelCaroBoard.Enabled = false;
                        }));
                        if (socket.isServer)
                        {
                            CaroBoard.CurrentPlayer = 1;
                            CaroBoard.ChangePlayer();
                        }
                    }
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>   //thay đổi giao diện
                    {
                        progressClock.Value = 0;
                        panelCaroBoard.Enabled = true;          
                        timerClock.Start();
                        CaroBoard.OtherPlayerMark(data.Point);
                    }));
                    newGameToolStripMenuItem.Enabled = true;                    
                    break;
                case (int)SocketCommand.QUIT:
                    timerClock.Stop();
                    MessageBox.Show("Đối thủ đã thoát","Thông báo");
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        panelCaroBoard.Enabled = false;
                    }));
                    if (socket.isServer)
                    {
                        socket.CloseConnect();
                    }
                    buttonLAN.Enabled = true;
                    newGameToolStripMenuItem.Enabled = false;
                    break;
                case (int)SocketCommand.START:
                    MessageBox.Show(data.Messege);
                    newGameToolStripMenuItem.Enabled = true;
                    panelCaroBoard.Enabled = true;
                    break;
                default:
                    break;
            }
            Listen(); 
        }
        #endregion
    }
}
