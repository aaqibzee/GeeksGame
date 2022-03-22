namespace GeeksGameTask.CustomControls
{
    public class DataConstants
    {
        #region Constants

        //Tags
        public const string JapaneseNationality = "Japanese";
        public const string ChineseNationality = "Chinese";
        public const string KoreanNationality = "Korean";
        public const string ThaiNationality = "Thai";

        //Others
        public const string GameBoardName = "GameBoard";
        public const string ScoreCardText = "Points ";
        public const string ImagesFormat = ".jpg";
        public const string TotalScore = "Total Points ";
        
        //Enumerations
        public enum Nationalities
        {
            Japanese,
            Chinese,
            Korean,
            Thai,
            MaxNationalties = 4,
        }
        public enum MaxImagesForNationality
        {
            Japanese = 3,
            Chinese = 3,
            Korean = 3,
            Thai = 3
        }
        public enum Direction
        {
            DownLeft,
            DownRight,
            UpLeft,
            UpRight
        }
        #endregion
    }

}
