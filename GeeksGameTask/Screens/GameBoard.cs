using GeeksGameTask.CustomControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeeksGameTask.Screens
{
    public partial class GameBoard : Form
    {
        #region Declarations
        private int maximumImagesToSpawn = 12;
        private int imageNumber = 0;
        private int lastImageNationality = 0;
        private int imagesSpawnedCount ;
        private int score ;
        private int rightmoveAward=20;
        private int wrongMovePenality = 5;
        private GameOverWindow gameOverWindow;
        private Random randomNumberGenerator;
        #endregion

        #region Public Methods
        public GameBoard()
        {
            InitializeComponent();
            Initialize();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// To Initialize 
        /// </summary>
        private void Initialize()
        {
            //Unregister, if events are already registred (incase of replay) , to avoid multiple triggers 
            movingImage.updateScore -= UpdateScores;
            movingImage.getNextImageToDraw -= GetNextImage;
            //Register delegate methods.
            movingImage.updateScore += UpdateScores;
            movingImage.getNextImageToDraw += GetNextImage;
            gameOverWindow = new GameOverWindow();
            randomNumberGenerator = new Random();
            gameOverWindow.Hide();
            gameOverWindow.GameReplayEvent+= Initialize;
            imagesSpawnedCount = 0;
            score = 0;
            movingImage.InitializeComponent();
            labelScore.Text = DataConstants.ScoreCardText + score.ToString();

        }
        /// <summary>
        /// To updated score on screen
        /// </summary>
        /// <param name="nationality"></param>
        private  void UpdateScores(string nationality)
        {
            if(GetNationalityName(this.lastImageNationality)== nationality)
            {
                score += rightmoveAward;
            }
            else
            {
                score -= wrongMovePenality;
            }
            labelScore.Text = DataConstants.ScoreCardText +score.ToString();
        }
        ///// <summary>
        ///// Get next image to spawn
        ///// </summary>
        ///// <returns></returns>
        private Image GetNextImage()
        {
            if (imagesSpawnedCount < maximumImagesToSpawn)
            {
                imagesSpawnedCount++;
                lastImageNationality = randomNumberGenerator.Next(1, (int)DataConstants.Nationalities.MaxNationalties + 1);
                imageNumber = randomNumberGenerator.Next(1, GetMaxImagesCount(lastImageNationality) + 1);
                return Image.FromFile(AppDomain.CurrentDomain.BaseDirectory +GetNationalityName(lastImageNationality) 
                    + "\\" + imageNumber.ToString() + DataConstants.ImagesFormat);
            }
            else
            {
                FormCollection openForms = Application.OpenForms;

                foreach (Form form in openForms)
                {
                    if (form.Name == gameOverWindow.Name)
                    {
                        return null;
                    }
                }
                this.Visible = false;
                gameOverWindow.Score.Text = DataConstants.TotalScore + score.ToString();
                gameOverWindow.Show();
                this.Hide();
                return null;
            }
        }

        /// <summary>
        /// Get max number of images for a nationality
        /// </summary>
        /// <param name="nationality"></param>
        /// <returns></returns>
        private int GetMaxImagesCount(int nationality)
        {
            switch (nationality)
            {
                case (int)DataConstants.Nationalities.Japanese:
                    {
                        return (int)DataConstants.MaxImagesForNationality.Japanese;
                    }
                case (int)DataConstants.Nationalities.Chinese:
                    {
                        return (int)DataConstants.MaxImagesForNationality.Chinese;
                    }
                case (int)DataConstants.Nationalities.Korean:
                    {
                        return (int)DataConstants.MaxImagesForNationality.Korean;
                    }
                default:
                    {
                        return (int)DataConstants.MaxImagesForNationality.Thai;
                    }
            }
        }

        /// <summary>
        /// Get nationality name for an integer, as per defined rules.
        /// </summary>
        /// <param name="nationality"></param>
        /// <returns></returns>
        private string GetNationalityName(int nationality)
        {
            switch (nationality)
            {
                case (int)DataConstants.Nationalities.Japanese:
                    {
                        return DataConstants.JapaneseNationality;
                    }
                case (int)DataConstants.Nationalities.Chinese:
                    {
                        return DataConstants.ChineseNationality;
                    }
                case (int)DataConstants.Nationalities.Korean:
                    {
                        return DataConstants.KoreanNationality;
                    }
                default:
                    {
                        return DataConstants.ThaiNationality;
                    }
            }
        }
        #endregion
    }
}
