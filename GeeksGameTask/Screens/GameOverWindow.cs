using GeeksGameTask.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GeeksGameTask.Utilities.ApplicationDelegates;

namespace GeeksGameTask.Screens
{
    public partial class GameOverWindow : Form
    {
        #region Declarations
        public event GameReplay GameReplayEvent;
        #endregion
        #region Public Methods
        public GameOverWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// Called when form is activated 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnActivated(EventArgs e)
        {
            Form gameBoardForm = GetGameBoardForm();
            if (gameBoardForm != null)
            {
                gameBoardForm.Hide();
            }
            base.OnActivated(e);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Handles replay button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="event"></param>
        private void Replay_Click(object sender, EventArgs @event)
        {
            Replay.Enabled = false;
            Form gameBoardForm = GetGameBoardForm();
            if(gameBoardForm!=null)
            {
                GameReplayEvent.Invoke();
                gameBoardForm.Show();
            }
            this.Hide();
            this.Dispose();
        }
        /// <summary>
        /// Get game board form
        /// </summary>
        /// <returns></returns>
        private Form GetGameBoardForm()
        {
            FormCollection openForms = Application.OpenForms;
            foreach (Form form in openForms)
            {
                if (form.Name == DataConstants.GameBoardName)
                {
                    return form;
                }
            }
            return null;
        }
        #endregion
    }
}
