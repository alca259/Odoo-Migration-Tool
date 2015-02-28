using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OdooTool.Helpers;
using PostgreSQLConnect;
using PostgreSQLConnect.Models;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PositionChangedEventArgs = Telerik.WinControls.UI.Data.PositionChangedEventArgs;

namespace OdooTool
{
    public partial class SequenceWindow : RadForm
    {
        #region Properties
        private bool isProcessRunning = false;
        #endregion

        #region Constructor
        public SequenceWindow()
        {
            InitializeComponent();
            SettingsManager.Initialize();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        #endregion

        #region Private methods
        private BindingSource LoadGridTable()
        {
            try
            {
                // Obtenemos la configuracion del destino
                SettingsModel modelDest = SettingsManager.GetXml(true);
                if (modelDest == null)
                    return null;

                // Inicializamos el manager de destino
                DatabaseManage managerDest = new DatabaseManage(modelDest);

                // Obtenemos las secuencias
                IEnumerable<string> sequences = managerDest.GetAllSequences().ToList();

                // Obtenemos las tablas
                List<string> tables = managerDest.GetTables().ToList();

                List<TableSequence> sequenceList = new List<TableSequence>();

                // Comparamos cada secuencia
                foreach (string seq in sequences)
                {
                    int cutIndex = seq.IndexOf("_id_seq", StringComparison.Ordinal);

                    if (cutIndex <= 0)
                    {
                        continue;
                    }

                    string tablename = seq.Substring(0, cutIndex);

                    if (!tables.Contains(tablename))
                    {
                        continue;
                    }

                    sequenceList.Add(new TableSequence
                    {
                        Active = true,
                        Sequence = seq,
                        Table = tablename,
                        MaxId = managerDest.GetMaxIdForTable(tablename)
                    });
                }

                // Asignamos los datos al grid
                var bindingList = new BindingList<TableSequence>(sequenceList);
                var source = new BindingSource(bindingList, null);
                return source;
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }

            return null;
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => RadMessageBox.Show(this, message, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation,
                    MessageBoxDefaultButton.Button1)));
            }
            else
            {
                RadMessageBox.Show(this, message, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation,
                   MessageBoxDefaultButton.Button1);   
            }
        }

        private List<string> GetSelectedNodes()
        {
            List<string> querys = new List<string>();

            try
            {
                foreach (GridViewRowInfo row in gridFields.Rows)
                {
                    var isSelected = (bool)row.Cells[0].Value;
                    if (!isSelected) continue;

                    string querySQL = string.Format("ALTER SEQUENCE {0} RESTART WITH {1}",
                        row.Cells[1].Value, row.Cells[3].Value);
                    querys.Add(querySQL);
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }

            return querys;
        }

        private void ExecuteAllRowsSelected()
        {
            // Obtenemos todas las filas seleccionadas
            List<string> querys = GetSelectedNodes();

            // Ejecutamos
            Migrator.ExecuteSequences(querys, progressBarResult);
        }

        #endregion

        #region Event methods
        private void btnSetDestinationServer_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(true);
            settingsForm.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (isProcessRunning)
            {
                throw new Exception("A process is already running.");
            }

            btnRefresh.Enabled = false;

            Thread backgroundThread = new Thread(() =>
            {
                isProcessRunning = true;

                var source = LoadGridTable();

                gridFields.BeginInvoke(new Action(() =>
                {
                    gridFields.DataSource = source;
                    gridFields.BestFitColumns();
                    gridFields.ReadOnly = false;
                    gridFields.AllowAddNewRow = false;
                    foreach (GridViewDataColumn column in gridFields.Columns)
                    {
                        column.ReadOnly = (column.Name != "Active");
                    }
                }));

                progressBarResult.BeginInvoke(new Action(() =>
                {
                    progressBarResult.Value1 = 0;
                }));

                btnRefresh.BeginInvoke(new Action(() =>
                {
                    btnRefresh.Enabled = true;
                }));

                isProcessRunning = false;
            });
            backgroundThread.Start();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (isProcessRunning)
            {
                throw new Exception("A process is already running.");
            }

            btnExecute.Enabled = false;

            Thread backgroundThread = new Thread(() =>
            {
                isProcessRunning = true;

                ExecuteAllRowsSelected();

                progressBarResult.BeginInvoke(new Action(() =>
                {
                    progressBarResult.Value1 = 0;
                }));

                btnExecute.BeginInvoke(new Action(() =>
                {
                    btnExecute.Enabled = true;
                }));

                isProcessRunning = false;
            });
            backgroundThread.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }

        #endregion
    }
}
