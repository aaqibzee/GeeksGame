
namespace GeeksGameTask.Screens
{
    partial class GameOverWindow
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
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Replay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.Location = new System.Drawing.Point(400, 250);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(209, 39);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "Game Over! ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(439, 350);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(95, 20);
            this.Score.TabIndex = 1;
            this.Score.Text = "Total Score";
            // 
            // Replay
            // 
            this.Replay.Location = new System.Drawing.Point(445, 420);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(117, 51);
            this.Replay.TabIndex = 2;
            this.Replay.Text = "Replay";
            this.Replay.UseVisualStyleBackColor = true;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // GameOverWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 753);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.GameOverLabel);
            this.MaximizeBox = false;
            this.Name = "GameOverWindow";
            this.Text = "GameOverWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameOverLabel;
        public System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button Replay;
    }
}