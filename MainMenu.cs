using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainMenu : Form
    {
        #region Variables
        // Singleton pattern. Create only one reference for object 
        public static MainMenu Instance { get; private set; }
        public string userName { get; private set; }

        public Image selectedAvatar;

        public DialogResult End;
        #endregion
        #region FormEvents
        public MainMenu()
        {
            Instance = this;
            this.StartPosition = FormStartPosition.CenterScreen; // Form position
            InitializeComponent();
            characterPanel.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {  
            if(End != DialogResult.Yes){
                End = MessageBox.Show("Do you want to close the window?",
                "", MessageBoxButtons.YesNoCancel);

                if (End != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            End = DialogResult.Yes;
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            characterPanel.Visible = true;
        }

        private void panelExit_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nickname"; // Reset the text box when the panel is closed
            characterPanel.Visible=false; 
        }

        private void startGameBTN_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text; // Get the user name
            if (userName.ToLower() == "nickname" ||
                userName.Trim()== "") // If user does not enter any key or the text box is empty, show warning
            {
                MessageBox.Show("Please enter a valid nickname!");
            }
            else
            {
                if (yellowRadioBTN.Checked) // Check for the selected avatar
                {
                    selectedAvatar = yellowBirdPic.Image;
                }
                else if (blueRadioBTN.Checked)
                {
                    selectedAvatar = blueBirdPic.Image;
                }
                GameScene gameScene = new GameScene();
                gameScene.Show();
                characterPanel.Visible = false;
                textBox1.Text = "Nickname"; // Reset the text box
                this.Hide();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // Clear the text box on click
        }

        private void h2pBTN_Click(object sender, EventArgs e)
        {
            howToPlayPanel.Visible = true; 
        }

        private void h2pPanelExitBTN_Click(object sender, EventArgs e)
        {
            howToPlayPanel.Visible=false;
        }
        #endregion
    }
}
