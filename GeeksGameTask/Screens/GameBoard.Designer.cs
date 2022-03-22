
namespace GeeksGameTask.Screens
{
    partial class GameBoard
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.labelJapanese = new System.Windows.Forms.Label();
            this.japaneseBox = new System.Windows.Forms.PictureBox();
            this.labelThai = new System.Windows.Forms.Label();
            this.thaiBox = new System.Windows.Forms.PictureBox();
            this.labelKorean = new System.Windows.Forms.Label();
            this.koreanBox = new System.Windows.Forms.PictureBox();
            this.labelChinese = new System.Windows.Forms.Label();
            this.chineseBox = new System.Windows.Forms.PictureBox();
            this.gameboardEnd = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.movingImage = new GeeksGameTask.CustomControls.MoveablePictureBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.japaneseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koreanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chineseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameboardEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJapanese
            // 
            this.labelJapanese.AutoSize = true;
            this.labelJapanese.Location = new System.Drawing.Point(16, 40);
            this.labelJapanese.Name = "labelJapanese";
            this.labelJapanese.Size = new System.Drawing.Size(70, 17);
            this.labelJapanese.TabIndex = 1;
            this.labelJapanese.Text = "Japanese";
            // 
            // japaneseBox
            // 
            this.japaneseBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.japaneseBox.Location = new System.Drawing.Point(2, 0);
            this.japaneseBox.Name = "japaneseBox";
            this.japaneseBox.Size = new System.Drawing.Size(100, 100);
            this.japaneseBox.TabIndex = 2;
            this.japaneseBox.TabStop = false;
            // 
            // labelThai
            // 
            this.labelThai.AutoSize = true;
            this.labelThai.Location = new System.Drawing.Point(930, 690);
            this.labelThai.Name = "labelThai";
            this.labelThai.Size = new System.Drawing.Size(36, 17);
            this.labelThai.TabIndex = 3;
            this.labelThai.Text = "Thai";
            // 
            // thaiBox
            // 
            this.thaiBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thaiBox.Location = new System.Drawing.Point(900, 650);
            this.thaiBox.Name = "thaiBox";
            this.thaiBox.Size = new System.Drawing.Size(100, 100);
            this.thaiBox.TabIndex = 4;
            this.thaiBox.TabStop = false;
            // 
            // labelKorean
            // 
            this.labelKorean.AutoSize = true;
            this.labelKorean.Location = new System.Drawing.Point(20, 690);
            this.labelKorean.Name = "labelKorean";
            this.labelKorean.Size = new System.Drawing.Size(54, 17);
            this.labelKorean.TabIndex = 5;
            this.labelKorean.Text = "Korean";
            // 
            // koreanBox
            // 
            this.koreanBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.koreanBox.Location = new System.Drawing.Point(2, 650);
            this.koreanBox.Name = "koreanBox";
            this.koreanBox.Size = new System.Drawing.Size(100, 100);
            this.koreanBox.TabIndex = 6;
            this.koreanBox.TabStop = false;
            // 
            // labelChinese
            // 
            this.labelChinese.AutoSize = true;
            this.labelChinese.Location = new System.Drawing.Point(920, 40);
            this.labelChinese.Name = "labelChinese";
            this.labelChinese.Size = new System.Drawing.Size(59, 17);
            this.labelChinese.TabIndex = 7;
            this.labelChinese.Text = "Chinese";
            // 
            // chineseBox
            // 
            this.chineseBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chineseBox.Location = new System.Drawing.Point(893, 0);
            this.chineseBox.Name = "chineseBox";
            this.chineseBox.Size = new System.Drawing.Size(107, 100);
            this.chineseBox.TabIndex = 8;
            this.chineseBox.TabStop = false;
            // 
            // gameboardEnd
            // 
            this.gameboardEnd.Location = new System.Drawing.Point(450, 1100);
            this.gameboardEnd.Name = "gameboardEnd";
            this.gameboardEnd.Size = new System.Drawing.Size(124, 88);
            this.gameboardEnd.TabIndex = 9;
            this.gameboardEnd.TabStop = false;
            this.gameboardEnd.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(131, 690);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(45, 17);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Score";
            // 
            // movingImage
            // 
            this.movingImage.Image = ((System.Drawing.Image)(resources.GetObject("movingImage.Image")));
            this.movingImage.Location = new System.Drawing.Point(450, 21);
            this.movingImage.Name = "movingImage";
            this.movingImage.Size = new System.Drawing.Size(102, 118);
            this.movingImage.TabIndex = 10;
            this.movingImage.TabStop = false;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 753);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.gameboardEnd);
            this.Controls.Add(this.labelChinese);
            this.Controls.Add(this.chineseBox);
            this.Controls.Add(this.labelKorean);
            this.Controls.Add(this.koreanBox);
            this.Controls.Add(this.labelThai);
            this.Controls.Add(this.thaiBox);
            this.Controls.Add(this.labelJapanese);
            this.Controls.Add(this.japaneseBox);
            this.Controls.Add(this.movingImage);
            this.MaximizeBox = false;
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            ((System.ComponentModel.ISupportInitialize)(this.japaneseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koreanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chineseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameboardEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelJapanese;
        private System.Windows.Forms.PictureBox japaneseBox;
        private System.Windows.Forms.Label labelThai;
        private System.Windows.Forms.PictureBox thaiBox;
        private System.Windows.Forms.Label labelKorean;
        private System.Windows.Forms.PictureBox koreanBox;
        private System.Windows.Forms.Label labelChinese;
        private System.Windows.Forms.PictureBox chineseBox;
        private System.Windows.Forms.PictureBox gameboardEnd;
        private CustomControls.MoveablePictureBox movingImage;
        private System.Windows.Forms.Label labelScore;
    }
}