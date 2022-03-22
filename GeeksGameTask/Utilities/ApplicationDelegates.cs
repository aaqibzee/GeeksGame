using System.Drawing;

namespace GeeksGameTask.Utilities
{
    public class ApplicationDelegates
    {
        #region Declarations
        public delegate void UpdateScore(string str);
        public delegate Image GetNextImage();
        public delegate void GameReplay();
        #endregion
    }
}
