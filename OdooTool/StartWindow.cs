using System.Windows.Forms;
using OdooTool.Helpers;
using PostgreSQLConnect;
using PostgreSQLConnect.Models;
using Telerik.WinControls.UI;

namespace OdooTool
{
    public partial class StartWindow : RadForm
    {
        private DatabaseManage manager;
        public StartWindow()
        {
            InitializeComponent();
            SettingsManager.Initialize();
        }

        //private void button3_Click(object sender, System.EventArgs e)
        //{
        //    var data = manager.GetTables();
        //    var data = manager.GetColumnsForTable("res_users");
        //    var data = manager.ExecuteQueryDataset("select * from res_users");
        //    var data = manager.ExecuteQueryList("select * from res_users");
            //        SettingsModel model = SettingsManager.GetXml();
            //if (model != null)
            //{
            //    manager = new DatabaseManage(model);
            //    //MasterTemplate.Data = manager.GetTables();
            //}
        //}

        private void btnSetSourceServer_Click(object sender, System.EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog(this);
        }

        private void btnSetDestinationServer_Click(object sender, System.EventArgs e)
        {
            Settings settingsForm = new Settings(true);
            settingsForm.ShowDialog(this);
        }
    }
}
