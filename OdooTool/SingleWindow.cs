using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class SingleWindow : RadForm
    {
        #region Properties
        private bool isProcessRunning = false;
        #endregion

        #region Constructor
        public SingleWindow()
        {
            InitializeComponent();
            SettingsManager.Initialize();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        #endregion

        #region Private methods

        private void LoadComboTables()
        {
            try
            {
                // Obtenemos la configuracion del origen
                SettingsModel model = SettingsManager.GetXml();
                if (model == null)
                    return;

                // Obtenemos la configuracion del destino
                SettingsModel modelDest = SettingsManager.GetXml(true);

                // Inicializamos el manager de origen
                DatabaseManage manager = new DatabaseManage(model);

                // Inicializamos el manager de destino
                DatabaseManage managerDest = new DatabaseManage(modelDest);

                // Obtenemos las tablas
                List<string> tables = manager.GetTables().ToList();

                int tableCount = tables.Count();
                int tableIndex = 0;

                foreach (string table in tables)
                {
                    tableIndex++;

                    progressBarResult.BeginInvoke(new Action(() =>
                    {
                        int newValue = (int) (((float) tableIndex/tableCount)*100);
                        if (newValue > 100)
                        {
                            newValue = 100;
                        }
                        progressBarResult.Value1 = newValue;
                    }));

                    // Buscamos la tabla en la base de datos de destino,
                    // si no existe, no la mostramos
                    if (!managerDest.GetTableWithName(table)) continue;

                    // Buscamos el numero de filas
                    string numRows = manager.GetCurrentRowsForTable(table);

                    // Agregamos la tabla al combo
                    srcTableDropdown.Items.Add(new RadListDataItem
                    {
                        Value = table,
                        Text = string.Format("{0} ({1})", table, numRows)
                    });
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private BindingSource LoadGridTable(string pTableName)
        {
            try
            {
                // Obtenemos la configuracion del origen
                SettingsModel model = SettingsManager.GetXml();
                if (model == null)
                    return null;

                // Obtenemos la configuracion del destino
                SettingsModel modelDest = SettingsManager.GetXml(true);
                if (modelDest == null)
                    return null;

                // Inicializamos el manager de origen
                DatabaseManage manager = new DatabaseManage(model);

                // Inicializamos el manager de destino
                DatabaseManage managerDest = new DatabaseManage(modelDest);

                List<string> listColumns = new List<string>();

                // Obtenemos las columnas de la tabla de origen
                IEnumerable<string> columns = manager.GetColumnsForTable(pTableName);
                foreach (string column in columns)
                {
                    // Buscamos la columna en la base de datos de destino,
                    // si no existe, no la guardaremos
                    if (!managerDest.GetColumnWithNameForTable(pTableName, column)) continue;

                    // Agregamos la columna al listado
                    listColumns.Add(column);
                }

                // Enviamos la tabla, y la lista de columnas validas, para que nos genere las querys
                List<FieldResult> listFields = Migrator.GenerateInserts(pTableName, listColumns, manager, managerDest, progressBarResult);

                // Asignamos los datos al grid
                var bindingList = new BindingList<FieldResult>(listFields);
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

        private QueryResult GetSelectedNodes()
        {
            QueryResult querys = new QueryResult
            {
                NumberOfItems = 0,
                Querys = new StringBuilder(),
                Results = new StringBuilder()
            };

            try
            {
                foreach (GridViewRowInfo row in gridFields.Rows)
                {
                    var isSelected = (bool)row.Cells[0].Value;
                    if (isSelected)
                    {
                        querys.Querys.Append(row.Cells[3].Value);
                        querys.NumberOfItems++;
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }

            return querys;
        }

        private string ExecuteAllRowsSelected()
        {
            // Obtenemos todas las filas seleccionadas
            QueryResult querys = GetSelectedNodes();

            // Ejecutamos
            return Migrator.ExecuteInserts(querys, progressBarResult);
        }

        #endregion

        #region Event methods
        private void btnSetSourceServer_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog(this);
        }

        private void btnSetDestinationServer_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(true);
            settingsForm.ShowDialog(this);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (isProcessRunning)
            {
                throw new Exception("A process is already running.");
            }

            refreshButton.Enabled = false;

            Thread backgroundThread = new Thread(() =>
            {
                isProcessRunning = true;
                
                LoadComboTables();

                progressBarResult.BeginInvoke(new Action(() =>
                {
                    progressBarResult.Value1 = 0;
                }));

                refreshButton.BeginInvoke(new Action(() =>
                {
                    refreshButton.Enabled = true;
                }));

                isProcessRunning = false;
            });
            backgroundThread.Start();
        }

        private void srcTableDropdown_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            var data = sender as RadDropDownList;
            if (data != null && data.SelectedValue != null)
            {
                if (isProcessRunning)
                {
                    throw new Exception("A process is already running.");
                }

                refreshButton.Enabled = false;
                srcTableDropdown.Enabled = false;

                Thread backgroundThread = new Thread(() =>
                {
                    isProcessRunning = true;

                    var source = LoadGridTable(data.SelectedValue.ToString());

                    gridFields.BeginInvoke(new Action(() =>
                    {
                        gridFields.DataSource = source;
                        gridFields.BestFitColumns();
                        gridFields.ReadOnly = false;
                        gridFields.AllowAddNewRow = false;
                        foreach (GridViewDataColumn column in gridFields.Columns)
                        {
                            column.ReadOnly = (column.Name != "Migrate");
                        }
                    }));

                    progressBarResult.BeginInvoke(new Action(() =>
                    {
                        progressBarResult.Value1 = 0;
                    }));

                    refreshButton.BeginInvoke(new Action(() =>
                    {
                        refreshButton.Enabled = true;
                    }));

                    srcTableDropdown.BeginInvoke(new Action(() =>
                    {
                        srcTableDropdown.Enabled = true;
                    }));

                    isProcessRunning = false;
                });
                backgroundThread.Start();
            }
        }

        private void btnDisableConst_Click(object sender, EventArgs e)
        {
            txtResult.Text += Migrator.ToggleContraints(srcTableDropdown.Items.Select(s => s.Value.ToString()));
        }

        private void btnEnableConst_Click(object sender, EventArgs e)
        {
            txtResult.Text += Migrator.ToggleContraints(srcTableDropdown.Items.Select(s => s.Value.ToString()), true);
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

                string resultado = ExecuteAllRowsSelected();

                txtResult.BeginInvoke(new Action(() =>
                {
                    txtResult.Text += resultado;
                }));

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
