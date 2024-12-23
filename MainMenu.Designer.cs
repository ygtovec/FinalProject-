namespace FinalProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnStart = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.characterPanel = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.startGameBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.blueRadioBTN = new System.Windows.Forms.RadioButton();
            this.yellowRadioBTN = new System.Windows.Forms.RadioButton();
            this.blueBirdPic = new System.Windows.Forms.PictureBox();
            this.yellowBirdPic = new System.Windows.Forms.PictureBox();
            this.howToPlayPanel = new System.Windows.Forms.Panel();
            this.h2pPanelExitBTN = new System.Windows.Forms.Button();
            this.h2pGBX = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.h2pLbl = new System.Windows.Forms.Label();
            this.h2pBTN = new System.Windows.Forms.Button();
            this.characterPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBirdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBirdPic)).BeginInit();
            this.howToPlayPanel.SuspendLayout();
            this.h2pGBX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(550, 240);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 80);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(550, 485);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(220, 80);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // characterPanel
            // 
            this.characterPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.characterPanel.Controls.Add(this.panelExit);
            this.characterPanel.Controls.Add(this.groupBox1);
            this.characterPanel.Location = new System.Drawing.Point(176, 83);
            this.characterPanel.Name = "characterPanel";
            this.characterPanel.Size = new System.Drawing.Size(973, 494);
            this.characterPanel.TabIndex = 2;
            this.characterPanel.Visible = false;
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
            this.panelExit.Click += new System.EventHandler(this.panelExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.titleLbl);
            this.groupBox1.Controls.Add(this.startGameBTN);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.blueRadioBTN);
            this.groupBox1.Controls.Add(this.yellowRadioBTN);
            this.groupBox1.Controls.Add(this.blueBirdPic);
            this.groupBox1.Controls.Add(this.yellowBirdPic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(91, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Details";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(213, 16);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(373, 26);
            this.titleLbl.TabIndex = 6;
            this.titleLbl.Text = "Choose Your Character and Nickname";
            // 
            // startGameBTN
            // 
            this.startGameBTN.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGameBTN.Location = new System.Drawing.Point(308, 265);
            this.startGameBTN.Name = "startGameBTN";
            this.startGameBTN.Size = new System.Drawing.Size(176, 49);
            this.startGameBTN.TabIndex = 4;
            this.startGameBTN.Text = "Start";
            this.startGameBTN.UseVisualStyleBackColor = true;
            this.startGameBTN.Click += new System.EventHandler(this.startGameBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.textBox1.Location = new System.Drawing.Point(334, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Nickname";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // blueRadioBTN
            // 
            this.blueRadioBTN.AutoSize = true;
            this.blueRadioBTN.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.blueRadioBTN.Location = new System.Drawing.Point(590, 148);
            this.blueRadioBTN.Name = "blueRadioBTN";
            this.blueRadioBTN.Size = new System.Drawing.Size(88, 24);
            this.blueRadioBTN.TabIndex = 4;
            this.blueRadioBTN.Text = "Blue Bird";
            this.blueRadioBTN.UseVisualStyleBackColor = true;
            // 
            // yellowRadioBTN
            // 
            this.yellowRadioBTN.AutoSize = true;
            this.yellowRadioBTN.Checked = true;
            this.yellowRadioBTN.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.yellowRadioBTN.Location = new System.Drawing.Point(101, 148);
            this.yellowRadioBTN.Name = "yellowRadioBTN";
            this.yellowRadioBTN.Size = new System.Drawing.Size(102, 24);
            this.yellowRadioBTN.TabIndex = 3;
            this.yellowRadioBTN.TabStop = true;
            this.yellowRadioBTN.Text = "Yellow Bird";
            this.yellowRadioBTN.UseVisualStyleBackColor = true;
            // 
            // blueBirdPic
            // 
            this.blueBirdPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueBirdPic.Image = ((System.Drawing.Image)(resources.GetObject("blueBirdPic.Image")));
            this.blueBirdPic.Location = new System.Drawing.Point(590, 82);
            this.blueBirdPic.Name = "blueBirdPic";
            this.blueBirdPic.Size = new System.Drawing.Size(75, 60);
            this.blueBirdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueBirdPic.TabIndex = 1;
            this.blueBirdPic.TabStop = false;
            // 
            // yellowBirdPic
            // 
            this.yellowBirdPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowBirdPic.Image = ((System.Drawing.Image)(resources.GetObject("yellowBirdPic.Image")));
            this.yellowBirdPic.Location = new System.Drawing.Point(101, 82);
            this.yellowBirdPic.Name = "yellowBirdPic";
            this.yellowBirdPic.Size = new System.Drawing.Size(75, 60);
            this.yellowBirdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowBirdPic.TabIndex = 2;
            this.yellowBirdPic.TabStop = false;
            // 
            // howToPlayPanel
            // 
            this.howToPlayPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.howToPlayPanel.Controls.Add(this.h2pPanelExitBTN);
            this.howToPlayPanel.Controls.Add(this.h2pGBX);
            this.howToPlayPanel.Location = new System.Drawing.Point(173, 86);
            this.howToPlayPanel.Name = "howToPlayPanel";
            this.howToPlayPanel.Size = new System.Drawing.Size(973, 494);
            this.howToPlayPanel.TabIndex = 8;
            this.howToPlayPanel.Visible = false;
            // 
            // h2pPanelExitBTN
            // 
            this.h2pPanelExitBTN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2pPanelExitBTN.ForeColor = System.Drawing.Color.Black;
            this.h2pPanelExitBTN.Location = new System.Drawing.Point(945, 3);
            this.h2pPanelExitBTN.Name = "h2pPanelExitBTN";
            this.h2pPanelExitBTN.Size = new System.Drawing.Size(25, 25);
            this.h2pPanelExitBTN.TabIndex = 7;
            this.h2pPanelExitBTN.Text = "X";
            this.h2pPanelExitBTN.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.h2pPanelExitBTN.UseVisualStyleBackColor = true;
            this.h2pPanelExitBTN.Click += new System.EventHandler(this.h2pPanelExitBTN_Click);
            // 
            // h2pGBX
            // 
            this.h2pGBX.Controls.Add(this.pictureBox1);
            this.h2pGBX.Controls.Add(this.label1);
            this.h2pGBX.Controls.Add(this.h2pLbl);
            this.h2pGBX.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.h2pGBX.ForeColor = System.Drawing.SystemColors.Control;
            this.h2pGBX.Location = new System.Drawing.Point(91, 3);
            this.h2pGBX.Name = "h2pGBX";
            this.h2pGBX.Size = new System.Drawing.Size(776, 426);
            this.h2pGBX.TabIndex = 4;
            this.h2pGBX.TabStop = false;
            this.h2pGBX.Text = "Mechanics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your must survive as long as possible! \r\nYour task is to avoid pipes and collect " +
    "coins which will be generated on random positions\r\nJust jump with space key or l" +
    "et it to fall down";
            // 
            // h2pLbl
            // 
            this.h2pLbl.AutoSize = true;
            this.h2pLbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2pLbl.Location = new System.Drawing.Point(313, 21);
            this.h2pLbl.Name = "h2pLbl";
            this.h2pLbl.Size = new System.Drawing.Size(132, 26);
            this.h2pLbl.TabIndex = 6;
            this.h2pLbl.Text = "How To Play";
            // 
            // h2pBTN
            // 
            this.h2pBTN.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2pBTN.Location = new System.Drawing.Point(550, 364);
            this.h2pBTN.Name = "h2pBTN";
            this.h2pBTN.Size = new System.Drawing.Size(220, 80);
            this.h2pBTN.TabIndex = 3;
            this.h2pBTN.Text = "How to Play";
            this.h2pBTN.UseVisualStyleBackColor = true;
            this.h2pBTN.Click += new System.EventHandler(this.h2pBTN_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1272, 713);
            this.Controls.Add(this.howToPlayPanel);
            this.Controls.Add(this.characterPanel);
            this.Controls.Add(this.h2pBTN);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.characterPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBirdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBirdPic)).EndInit();
            this.howToPlayPanel.ResumeLayout(false);
            this.h2pGBX.ResumeLayout(false);
            this.h2pGBX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel characterPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button startGameBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton blueRadioBTN;
        private System.Windows.Forms.RadioButton yellowRadioBTN;
        private System.Windows.Forms.PictureBox blueBirdPic;
        private System.Windows.Forms.PictureBox yellowBirdPic;
        private System.Windows.Forms.Button panelExit;
        private System.Windows.Forms.Panel howToPlayPanel;
        private System.Windows.Forms.Button h2pPanelExitBTN;
        private System.Windows.Forms.GroupBox h2pGBX;
        private System.Windows.Forms.Label h2pLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button h2pBTN;
    }
}

