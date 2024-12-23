using FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class GameScene : Form
    {
        #region Variables

        Timer[] timers = new Timer[4]; // Timers on form
        int gravity = 0, pipeSpeed = 5; 
        int score = 0;

        Random random = new Random();

        List<PictureBox> pipes = new List<PictureBox>(); // Obstacles
        List<PictureBox> coins = new List<PictureBox>(); // Coins for additional points

        int groundSpeed=8, groundDirection=1; // Ground moving speed and direction
        #endregion

        #region FormEvents
        public GameScene()
        {
            this.StartPosition = FormStartPosition.CenterScreen; // Set screen position
            InitializeComponent();
            timers[0] = gameManager; // Set timers for array
            timers[1] = scoreManager;
            timers[2] = pipeSpawner;
            timers[3] = coinTimer;
            playerCharacter.Image= MainMenu.Instance.selectedAvatar; // Set the selected avatar
            playerCharacter.Size = new Size(55, 52); // Set playable size
            playerCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        private void GameScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MainMenu.Instance.End != DialogResult.Yes) // Check the exit with only one variable
            {
                e.Cancel = true;
            }
            Application.Exit();
        }

        private void PlayerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // If space key is pressed decrease the gravity
            {
                gravity = -15;
            }
        }

        private void PlayerKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // If space key is released increase the gravity
            {
                gravity = +15;
            }
        }

        private void scoreManager_Tick(object sender, EventArgs e)
        {
            score += 5; // Increase score by 5 points for every 2 secs
            scoreLbl.Text = "Score: " + score; // Update the screen info
            if (score > 35)
            {
                pipeSpeed = 10; // Increase pipe speed
                pipeSpawner.Interval = 1500; // Increase spawner interval to generate more pipes in a smaller time
                coinTimer.Interval = 15000; // Increase coin timer internval to generate more coins
            }
        }

        private void gameManager_Tick(object sender, EventArgs e)
        {
            // Set player's y position according to space key press
            playerCharacter.Top += gravity;
            //Check if the player intersects with ground or roof
            if(playerCharacter.Bounds.IntersectsWith(ground.Bounds) 
                || playerCharacter.Top < -25) // If yes, end the game
            {
                EndGame();
            }
            //If an any pipe generated make them move and check if they intersect with the player
            if (pipes.Count > 0)
            {
                for (int i = 0; i < pipes.Count; i++)
                {
                    pipes[i].Left -= pipeSpeed; // Make the pipes move
                    if (playerCharacter.Bounds.IntersectsWith(pipes[i].Bounds)) // Player and pipe intersect
                    {
                        EndGame(); //  Finish the game
                    }
                }
            }
            if (coins.Count > 0) { //If an any coin generated make them move and check if they intersect with the player
                for (int i = 0; i < coins.Count; i++)
                {
                    coins[i].Left -= pipeSpeed; // Move the coins at the same speed as the pipes
                    if (playerCharacter.Bounds.IntersectsWith(coins[i].Bounds)) 
                    {
                        score += 10; // If they intersect with the player add additional points
                        scoreLbl.Text = "Score: " + score; // Update the score text
                        RemoveAfterDelay(coins[i], 0); // Destroy them after the intersect
                    }
                }
            }

            GroundAnimation(); // Ground animation
        }
        //Operate for every 3 secs (default)
        private void pipeSpawner_Tick(object sender, EventArgs e)
        {
            PipeManager(); //Generate new pipes and set their positions 
            for (int i = 0; i < pipes.Count; i++) //Destroy them after 10 secs
            {
                RemoveAfterDelay(pipes[i], 10000); // Destroy the pipes after 10 secs
            }
            
        }
        private void CoinTimerTick(object sender, EventArgs e) // Operate for every 20 secs (default)
        {
            CoinManager(); // Generate new coins and set position, size and location 
            for (int i = 0; i < coins.Count; i++)
            {
                RemoveAfterDelay(coins[i], 10000); // Destroy the coins after 10 secs
            }
        }
        private void restartBTN_Click(object sender, EventArgs e) // Reset all the objects and variables
        {
            foreach (PictureBox pipe in pipes)
            {
                pipe.Dispose(); // Release the objects
            }
            foreach (PictureBox coin in coins)
            {
                coin.Dispose(); // Release the objects
            }
            pipes.Clear(); // Reset the collection
            coins.Clear(); // Reset the coin collection)

            score = 0; 
            scoreLbl.Text = "Score: " + score; // Reset the score and text on screen
            pipeSpeed = 5; // Default pipe speed 
            pipeSpawner.Interval = 3000; // Default interval for pipe spawner
            coinTimer.Interval = 20000; // Default interval for coin timer
            endGamePanel.Visible = false; // Disappear the endgame panel
            this.Focus(); // Set the focus on game screen after the ending panel
            playerCharacter.Location = new Point(126, 163); // Reset position
            ground.Location = new Point(-174,632); // Reset ground position
            // Start timers
            foreach(Timer timer in timers)
            {
                timer.Start();
            }
        }
        private void returnMenuBTN_Click(object sender, EventArgs e)
        {
            MainMenu.Instance.Show(); // Show main menu
            this.Hide();
        }

        #endregion

        #region CustomMethods
        private void EndGame() //Finish the game
        {
            // Stop the timers
            foreach (Timer timer in timers)
            {
                timer.Stop();
            }
            // Get the player's avatar and name in main menu
            playerNameLBL.Text = MainMenu.Instance.userName;
            playerAvatar.Image = playerCharacter.Image;
            playerAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            // Show ending screen
            endGamePanel.Visible = true;
            totalScoreLBL.Text = "Total score: " + score;
        }

        private void PipeManager() // Set general rules for pipe objects 
        {
            // Get the image from the directory path 
            // Set the location
            // Set width and height
            // Size mode
            // Set the tag for possible checks
            PictureBox upperBox = new PictureBox
            {
                Image = Image.FromFile(Directory.GetParent(Application.StartupPath).Parent.FullName +
                "\\Sprites\\pipedown.png"), 
                Location = new Point(random.Next(1200, 1400), random.Next(-280, -250)), 
                Width = 91,
                Height = 458, 
                SizeMode = PictureBoxSizeMode.StretchImage, 
                Tag = "Pipe" 
            };
            PictureBox lowerBox = new PictureBox
            {
                Image = Image.FromFile(Directory.GetParent(Application.StartupPath).Parent.FullName +
                "\\Sprites\\pipe.png"), 
                Location = new Point(random.Next(1200, 1400), random.Next(365, 460)),
                Width = 91,
                Height = 458,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = "Pipe"
            };
            //Add them to the scene
            this.Controls.Add(upperBox); 
            this.Controls.Add(lowerBox);
            // List them on pipes collection
            pipes.Add(upperBox);
            pipes.Add(lowerBox);
        }
        private void CoinManager() // Set general rules for coins
        {
            // Get the image from the directory path 
            // Set the location
            // Set width and height
            // Size mode
            // Set the tag for possible checks
            PictureBox coin = new PictureBox()
            {
                Image = Image.FromFile(Directory.GetParent(Application.StartupPath).Parent.FullName +
                "\\Sprites\\coin.png"),
                Location = new Point(random.Next(1200, 1400), random.Next(250, 400)),
                Width = 42,
                Height = 42,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = "Coin"
            };
            this.Controls.Add(coin); // Add them to the scene
            coins.Add(coin); // List them on coins collection
        }
        //Destroy the object after determined time on call
        private async void RemoveAfterDelay(PictureBox instance, int delay) 
        {
            await Task.Delay(delay); // Wait for (delay) miliseconds
            if (instance.Tag == "Pipe") // Determine the object
            {
                if (pipes.Contains(instance)) // If collection is not null
                {
                    this.Controls.Remove(instance); // Destroy the object and remove it from the collection
                    pipes.Remove(instance);
                    instance.Dispose();
                }
            }
            else if (instance.Tag == "Coin") // Determine the object
            {
                if (coins.Contains(instance)) // If collection is not null
                {
                    this.Controls.Remove(instance); // Destroy the object and remove it from the collection
                    coins.Remove(instance);
                    instance.Dispose();
                }
            }
        }

        private void GroundAnimation() // Move the ground right to left depending on the position
        {
            ground.Left += groundSpeed * groundDirection; 
            if (ground.Left > -10)
            {
                groundDirection = -1; // Move to left
            }
            else if (ground.Left < -140)
            {

                groundDirection = 1; // Move to right
            }
        }

        #endregion
    }
}
