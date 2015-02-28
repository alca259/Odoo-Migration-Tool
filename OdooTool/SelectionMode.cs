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
                singleWindow.Show();
                //Dispose(false);
                Close();
            }

            if (radioAllTables.IsChecked)
            {
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                //Dispose(false);
                Close();
            }
        }
        #endregion
    }
}
