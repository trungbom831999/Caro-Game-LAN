namespace CaroGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelCaroBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureAvatarGame = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLAN = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.pictureBoxMark = new System.Windows.Forms.PictureBox();
            this.progressClock = new System.Windows.Forms.ProgressBar();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYourName = new System.Windows.Forms.TextBox();
            this.pictureBoxYourMark = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatarGame)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYourMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCaroBoard
            // 
            this.panelCaroBoard.Location = new System.Drawing.Point(12, 31);
            this.panelCaroBoard.Name = "panelCaroBoard";
            this.panelCaroBoard.Size = new System.Drawing.Size(921, 757);
            this.panelCaroBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureAvatarGame);
            this.panel2.Location = new System.Drawing.Point(944, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 260);
            this.panel2.TabIndex = 1;
            // 
            // pictureAvatarGame
            // 
            this.pictureAvatarGame.BackgroundImage = global::CaroGame.Properties.Resources.weplay_vn_caro_xogame;
            this.pictureAvatarGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureAvatarGame.Location = new System.Drawing.Point(3, 5);
            this.pictureAvatarGame.Name = "pictureAvatarGame";
            this.pictureAvatarGame.Size = new System.Drawing.Size(320, 252);
            this.pictureAvatarGame.TabIndex = 0;
            this.pictureAvatarGame.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBoxYourMark);
            this.panel3.Controls.Add(this.textBoxYourName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonPlay);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonLAN);
            this.panel3.Controls.Add(this.textBoxIP);
            this.panel3.Controls.Add(this.pictureBoxMark);
            this.panel3.Controls.Add(this.progressClock);
            this.panel3.Controls.Add(this.textBoxPlayerName);
            this.panel3.Location = new System.Drawing.Point(944, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 491);
            this.panel3.TabIndex = 2;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.Font = new System.Drawing.Font("UVN Banh Mi", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonPlay.Location = new System.Drawing.Point(0, 378);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(235, 52);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mỗi lượt 10 giây suy nghĩ\r\n5 quân thẳng == thắng";
            // 
            // buttonLAN
            // 
            this.buttonLAN.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLAN.Font = new System.Drawing.Font("UVN Banh Mi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLAN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLAN.Location = new System.Drawing.Point(0, 301);
            this.buttonLAN.Name = "buttonLAN";
            this.buttonLAN.Size = new System.Drawing.Size(235, 54);
            this.buttonLAN.TabIndex = 4;
            this.buttonLAN.Text = "Connect";
            this.buttonLAN.UseVisualStyleBackColor = false;
            this.buttonLAN.Click += new System.EventHandler(this.buttonLAN_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(0, 273);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(232, 22);
            this.textBoxIP.TabIndex = 3;
            // 
            // pictureBoxMark
            // 
            this.pictureBoxMark.Location = new System.Drawing.Point(243, 184);
            this.pictureBoxMark.Name = "pictureBoxMark";
            this.pictureBoxMark.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMark.TabIndex = 2;
            this.pictureBoxMark.TabStop = false;
            // 
            // progressClock
            // 
            this.progressClock.Location = new System.Drawing.Point(0, 184);
            this.progressClock.Name = "progressClock";
            this.progressClock.Size = new System.Drawing.Size(232, 23);
            this.progressClock.TabIndex = 1;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(0, 228);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.ReadOnly = true;
            this.textBoxPlayerName.Size = new System.Drawing.Size(232, 22);
            this.textBoxPlayerName.TabIndex = 0;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Round\r\n";
            // 
            // textBoxYourName
            // 
            this.textBoxYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYourName.Location = new System.Drawing.Point(3, 75);
            this.textBoxYourName.Name = "textBoxYourName";
            this.textBoxYourName.ReadOnly = true;
            this.textBoxYourName.Size = new System.Drawing.Size(171, 27);
            this.textBoxYourName.TabIndex = 8;
            // 
            // pictureBoxYourMark
            // 
            this.pictureBoxYourMark.Location = new System.Drawing.Point(214, 41);
            this.pictureBoxYourMark.Name = "pictureBoxYourMark";
            this.pictureBoxYourMark.Size = new System.Drawing.Size(109, 101);
            this.pictureBoxYourMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYourMark.TabIndex = 9;
            this.pictureBoxYourMark.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your Name\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCaroBoard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Car Game nkT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatarGame)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYourMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCaroBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureAvatarGame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLAN;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.PictureBox pictureBoxMark;
        private System.Windows.Forms.ProgressBar progressClock;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textBoxYourName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxYourMark;
        private System.Windows.Forms.Label label3;
    }
}

