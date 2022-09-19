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
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.score_Lbl = new System.Windows.Forms.Label();
            this.points_Lbl = new System.Windows.Forms.Label();
            this.gameOver_Lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameOver_Lbl);
            this.playground.Controls.Add(this.points_Lbl);
            this.playground.Controls.Add(this.score_Lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1102, 637);
            this.playground.TabIndex = 0;
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
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(124, 325);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // score_Lbl
            // 
            this.score_Lbl.AutoSize = true;
            this.score_Lbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_Lbl.Location = new System.Drawing.Point(60, 9);
            this.score_Lbl.Name = "score_Lbl";
            this.score_Lbl.Size = new System.Drawing.Size(156, 65);
            this.score_Lbl.TabIndex = 2;
            this.score_Lbl.Text = "Score:";
            // 
            // points_Lbl
            // 
            this.points_Lbl.AutoSize = true;
            this.points_Lbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.points_Lbl.Location = new System.Drawing.Point(250, 9);
            this.points_Lbl.Name = "points_Lbl";
            this.points_Lbl.Size = new System.Drawing.Size(54, 65);
            this.points_Lbl.TabIndex = 3;
            this.points_Lbl.Text = "0";
            this.points_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOver_Lbl
            // 
            this.gameOver_Lbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOver_Lbl.Location = new System.Drawing.Point(297, 86);
            this.gameOver_Lbl.Name = "gameOver_Lbl";
            this.gameOver_Lbl.Size = new System.Drawing.Size(428, 329);
            this.gameOver_Lbl.TabIndex = 4;
            this.gameOver_Lbl.Text = "Game Over!\r\n\r\nPress F1 to Restart\r\n\r\nPress Esc to Exit";
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
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label gameOver_Lbl;
        private System.Windows.Forms.Label points_Lbl;
        private System.Windows.Forms.Label score_Lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
    }
}
