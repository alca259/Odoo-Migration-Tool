using System;
using Telerik.WinControls.UI;

namespace OdooTool
{
    public partial class SelectionMode : RadForm
    {
        #region Constructor
        public SelectionMode()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (radioOneTable.IsChecked)
            {
                SingleWindow singleWindow = new SingleWindow();
                singleWindow.Disposed += closeThisForm;
                singleWindow.Closed += closeThisForm;
                singleWindow.Show();
                Hide();
            }

            if (radioAllTables.IsChecked)
            {
                StartWindow startWindow = new StartWindow();
                startWindow.Disposed += closeThisForm;
                startWindow.Closed += closeThisForm;
                startWindow.Show();
                Hide();
            }

            if (radioSequences.IsChecked)
            {
                SequenceWindow window = new SequenceWindow();
                window.Disposed += closeThisForm;
                window.Closed += closeThisForm;
                window.Show();
                Hide();
            }
        }

        void closeThisForm(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
