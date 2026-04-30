using System;
using System.Windows.Forms;

namespace TRex
{
    public partial class TRexMainClass : Form
    {
        bool jumping = false;
        bool isGameOver = false;
        Random random = new Random();

        int jumpSpeed;
        int gravity = 1;
        int force = 12;

        int score = 0;
        int obstacleSpeed = 8;
        int position = 0;

        int k = 1;

        public TRexMainClass()
        {
            InitializeComponent();

            // 🔥 IMPORTANT
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            this.KeyDown += KeyIsDownEvent;
            this.KeyUp += KeyIsUpEvent;

            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;

            GameReset();
        }

        private void GameReset()
        {
            jumping = false;
            force = 12;
            score = 0;
            jumpSpeed = 0;
            obstacleSpeed = 8;
            k = 1;

            txtScoreLabel.Text = "Score: " + score;
            trexPictureBox.Image = TRex_RunnerGame.Properties.Resources.running;
            isGameOver = false;
            trexPictureBox.Top = 337;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTimer.Start();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            trexPictureBox.Top += jumpSpeed;
            jumpSpeed += gravity;

            txtScoreLabel.Text = "Score: " + score;

            if (trexPictureBox.Top > 367)
            {
                trexPictureBox.Top = 367;
                jumpSpeed = 0;
                jumping = false;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (trexPictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trexPictureBox.Image = TRex_RunnerGame.Properties.Resources.dead;
                        txtScoreLabel.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }

            if (score > 5 * k)
            {
                k++;
                obstacleSpeed += 1;
            }
        }

        private void KeyIsDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
                jumpSpeed = -15;
            }
        }

        private void KeyIsUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
    }
}