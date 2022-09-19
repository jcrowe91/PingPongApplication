namespace PingPongGame
{
    partial class gameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameOverLbl);
            this.playground.Controls.Add(this.pointsLbl);
            this.playground.Controls.Add(this.scoreLbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1102, 637);
            this.playground.TabIndex = 0;
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.BackColor = System.Drawing.Color.Blue;
            this.gameOverLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLbl.Location = new System.Drawing.Point(297, 86);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(493, 401);
            this.gameOverLbl.TabIndex = 4;
            this.gameOverLbl.Text = "Game Over!\r\n\r\nPress Enter to Restart\r\n\r\nPress Esc to Exit";
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointsLbl.Location = new System.Drawing.Point(250, 9);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(54, 65);
            this.pointsLbl.TabIndex = 3;
            this.pointsLbl.Text = "0";
            this.pointsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLbl.Location = new System.Drawing.Point(60, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(156, 65);
            this.scoreLbl.TabIndex = 2;
            this.scoreLbl.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(124, 325);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(418, 591);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 637);
            this.Controls.Add(this.playground);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
    }
}
