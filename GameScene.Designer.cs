namespace FinalProject
{
    partial class GameScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScene));
            this.scoreLbl = new System.Windows.Forms.Label();
            this.gameManager = new System.Windows.Forms.Timer(this.components);
            this.scoreManager = new System.Windows.Forms.Timer(this.components);
            this.pipeSpawner = new System.Windows.Forms.Timer(this.components);
            this.endGamePanel = new System.Windows.Forms.Panel();
            this.playerNameLBL = new System.Windows.Forms.Label();
            this.panelExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.returnMenuBTN = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.restartBTN = new System.Windows.Forms.Button();
            this.playerAvatar = new System.Windows.Forms.PictureBox();
            this.playerCharacter = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.coinTimer = new System.Windows.Forms.Timer(this.components);
            this.endGamePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(12, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(102, 28);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Score:  0";
            // 
            // gameManager
            // 
            this.gameManager.Enabled = true;
            this.gameManager.Interval = 20;
            this.gameManager.Tick += new System.EventHandler(this.gameManager_Tick);
            // 
            // scoreManager
            // 
            this.scoreManager.Enabled = true;
            this.scoreManager.Interval = 2000;
            this.scoreManager.Tick += new System.EventHandler(this.scoreManager_Tick);
            // 
            // pipeSpawner
            // 
            this.pipeSpawner.Enabled = true;
            this.pipeSpawner.Interval = 3000;
            this.pipeSpawner.Tick += new System.EventHandler(this.pipeSpawner_Tick);
            // 
            // endGamePanel
            // 
            this.endGamePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.endGamePanel.Controls.Add(this.playerNameLBL);
            this.endGamePanel.Controls.Add(this.playerAvatar);
            this.endGamePanel.Controls.Add(this.panelExit);
            this.endGamePanel.Controls.Add(this.groupBox1);
            this.endGamePanel.Location = new System.Drawing.Point(234, 163);
            this.endGamePanel.Name = "endGamePanel";
            this.endGamePanel.Size = new System.Drawing.Size(860, 326);
            this.endGamePanel.TabIndex = 6;
            this.endGamePanel.Visible = false;
            // 
            // playerNameLBL
            // 
            this.playerNameLBL.AutoSize = true;
            this.playerNameLBL.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLBL.ForeColor = System.Drawing.SystemColors.Window;
            this.playerNameLBL.Location = new System.Drawing.Point(83, 62);
            this.playerNameLBL.Name = "playerNameLBL";
            this.playerNameLBL.Size = new System.Drawing.Size(119, 28);
            this.playerNameLBL.TabIndex = 7;
            this.playerNameLBL.Text = "Nickname";
            // 
            // panelExit
            // 
            this.panelExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelExit.ForeColor = System.Drawing.Color.Black;
            this.panelExit.Location = new System.Drawing.Point(945, 3);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(25, 25);
            this.panelExit.TabIndex = 7;
            this.panelExit.Text = "X";
            this.panelExit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.panelExit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.returnMenuBTN);
            this.groupBox1.Controls.Add(this.titleLbl);
            this.groupBox1.Controls.Add(this.restartBTN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(260, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 236);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "End Game";
            // 
            // returnMenuBTN
            // 
            this.returnMenuBTN.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.returnMenuBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.returnMenuBTN.Location = new System.Drawing.Point(207, 111);
            this.returnMenuBTN.Name = "returnMenuBTN";
            this.returnMenuBTN.Size = new System.Drawing.Size(203, 31);
            this.returnMenuBTN.TabIndex = 7;
            this.returnMenuBTN.Text = "Exit to main menu";
            this.returnMenuBTN.UseVisualStyleBackColor = true;
            this.returnMenuBTN.Click += new System.EventHandler(this.returnMenuBTN_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.titleLbl.Location = new System.Drawing.Point(262, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(83, 22);
            this.titleLbl.TabIndex = 6;
            this.titleLbl.Text = "You lost!";
            // 
            // restartBTN
            // 
            this.restartBTN.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.restartBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restartBTN.Location = new System.Drawing.Point(207, 74);
            this.restartBTN.Name = "restartBTN";
            this.restartBTN.Size = new System.Drawing.Size(203, 31);
            this.restartBTN.TabIndex = 4;
            this.restartBTN.Text = "Restart";
            this.restartBTN.UseVisualStyleBackColor = true;
            this.restartBTN.Click += new System.EventHandler(this.restartBTN_Click);
            // 
            // playerAvatar
            // 
            this.playerAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerAvatar.InitialImage = null;
            this.playerAvatar.Location = new System.Drawing.Point(98, 93);
            this.playerAvatar.Name = "playerAvatar";
            this.playerAvatar.Size = new System.Drawing.Size(55, 52);
            this.playerAvatar.TabIndex = 7;
            this.playerAvatar.TabStop = false;
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCharacter.InitialImage = null;
            this.playerCharacter.Location = new System.Drawing.Point(102, 166);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(55, 52);
            this.playerCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCharacter.TabIndex = 5;
            this.playerCharacter.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-107, 626);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1681, 185);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // coinTimer
            // 
            this.coinTimer.Enabled = true;
            this.coinTimer.Interval = 20000;
            this.coinTimer.Tick += new System.EventHandler(this.CoinTimerTick);
            // 
            // GameScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 811);
            this.Controls.Add(this.endGamePanel);
            this.Controls.Add(this.playerCharacter);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.scoreLbl);
            this.DoubleBuffered = true;
            this.Name = "GameScene";
            this.Text = "GameScene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameScene_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayerKeyUp);
            this.endGamePanel.ResumeLayout(false);
            this.endGamePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Timer gameManager;
        private System.Windows.Forms.Timer scoreManager;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox playerCharacter;
        private System.Windows.Forms.Timer pipeSpawner;
        private System.Windows.Forms.Panel endGamePanel;
        private System.Windows.Forms.Button panelExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button restartBTN;
        private System.Windows.Forms.Label playerNameLBL;
        private System.Windows.Forms.PictureBox playerAvatar;
        private System.Windows.Forms.Button returnMenuBTN;
        private System.Windows.Forms.Timer coinTimer;
    }
}