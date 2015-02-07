using System.Windows.Forms;
using OdooTool.Helpers;
using PostgreSQLConnect.Models;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace OdooTool
{
    public partial class Settings : RadForm
    {
        private bool destination { get; set; }

        public Settings()
        {
            InitializeComponent();
            SettingsManager.Initialize();
            SettingsModel model = SettingsManager.GetXml();
            if (model != null)
            {
                txtHost.Text = model.Host;
                txtPort.Value = model.Port;
                txtUser.Text = model.User;
                txtPass.Text = model.Password;
                txtDB.Text = model.Database;
            }
            RadMessageBox.SetThemeName("VisualStudio2012Light"); 
        }
        public Settings(bool isDestination)
        {
            InitializeComponent();
            SettingsManager.Initialize();
            SettingsModel model = SettingsManager.GetXml(isDestination);
            if (model != null)
            {
                txtHost.Text = model.Host;
                txtPort.Value = model.Port;
                txtUser.Text = model.User;
                txtPass.Text = model.Password;
                txtDB.Text = model.Database;
            }
            RadMessageBox.SetThemeName("VisualStudio2012Light");
            destination = isDestination;
        }

        private void DisplayMessage(string message)
        {
            RadMessageBox.Show(this, message, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (txtHost.Text.Length == 0)
            {
                DisplayMessage("Host cannot be empty");
                return;
            }
            if (txtPort.Value <= 0)
            {
                DisplayMessage("Port cannot be empty");
                return;
            }
            if (txtUser.Text.Length == 0)
            {
                DisplayMessage("User cannot be empty");
                return;
            }
            if (txtPass.Text.Length == 0)
            {
                DisplayMessage("Password cannot be empty");
                return;
            }
            if (txtDB.Text.Length == 0)
            {
                DisplayMessage("Database cannot be empty");
                return;
            }
            SettingsManager.SetXml(new SettingsModel
            {
                Host = txtHost.Text,
                Port = (int)txtPort.Value,
                User = txtUser.Text,
                Password = txtPass.Text,
                Database = txtDB.Text,
                Destiny = !destination ? "SOURCE" : "DESTINATION",
            });
            
            Dispose();
        }

    }
}
