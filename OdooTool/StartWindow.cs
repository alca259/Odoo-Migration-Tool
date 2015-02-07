using System.Windows.Forms;
using PostgreSQLConnect;

namespace OdooTool
{
    public partial class StartWindow : Form
    {
        private DatabaseManage manager;
        public StartWindow()
        {
            InitializeComponent();
            manager = new DatabaseManage("127.0.0.1", 5432, "openpg", "openpg", "desarrollo");
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var data = manager.GetTables();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            var data = manager.GetColumnsForTable("res_users");
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            var data = manager.ExecuteQueryDataset("select * from res_users");
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            var data = manager.ExecuteQueryList("select * from res_users");
        }
    }
}
