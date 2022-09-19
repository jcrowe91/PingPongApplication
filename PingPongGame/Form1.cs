using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class gameForm : Form
    {
        public int speedLeft = 10;
        public int speedTop = 10;
        public int points = 0;


        public gameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playground.Bottom - (playground.Bottom / 10);

            gameOverLbl.Left = (playground.Width / 2) - (gameOverLbl.Width / 2);
            gameOverLbl.Top = (playground.Height / 2) - (gameOverLbl.Height / 2);
            gameOverLbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetPlayerPosition();
            SetBallSpeed();
            SetupGameSettings();
            CheckBallLeft();
            CheckBallRight();
            CheckBallTop();
            CheckBallBottom();
        }

        private void SetBallSpeed()
        {
            ball.Left += speedLeft;
            ball.Top += speedTop;
        }

        private void SetPlayerPosition()
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
        }

        private void SetupGameSettings()
        {
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speedTop += 10;
                speedLeft += 10;
                speedTop = -speedTop;
                points += 1;
                pointsLbl.Text = points.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 225), r.Next(150, 225), r.Next(150, 225));
            }
        }

        private void CheckBallLeft()
        {
            if (ball.Left <= playground.Left)
            {
                speedLeft = -speedLeft;
            }
        }

        private void CheckBallRight()
        {
            if (ball.Right >= playground.Right)
            {
                speedLeft = -speedLeft;
            }
        }

        private void CheckBallTop()
        {
            if (ball.Top <= playground.Top)
            {
                speedTop = -speedTop;
            }
        }

        private void CheckBallBottom()
        {
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameOverLbl.Visible = true;
            }
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            
            if (e.KeyCode == Keys.Enter)
            {
                ball.Top = 50;
                ball.Left = 50;
                speedLeft = 6;
                speedTop = 6;
                pointsLbl.Text = "0";
                timer1.Enabled = true;
                gameOverLbl.Visible = false;
                playground.BackColor = Color.White;
            }
        }
    }
}
