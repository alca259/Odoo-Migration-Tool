using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        private QueryResult result { get; set; }
        private bool isProcessRunning = false;
        #endregion

        #region Constructor
        public SingleWindow()
        {
            InitializeComponent();
            SettingsManager.Initialize();
            result = new QueryResult();
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
                IEnumerable<string> tables = manager.GetTables();
                foreach (string table in tables)
                {
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

        private void LoadGridTable(string pTableName)
        {
            try
            {
                // Obtenemos la configuracion del origen
                SettingsModel model = SettingsManager.GetXml();
                if (model == null)
                    return;

                // Obtenemos la configuracion del destino
                SettingsModel modelDest = SettingsManager.GetXml(true);
                if (modelDest == null)
                    return;

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
                List<FieldResult> listFields = Migrator.GenerateInserts(pTableName, listColumns, manager, managerDest);

                // Asignamos los datos al grid
                var bindingList = new BindingList<FieldResult>(listFields);
                var source = new BindingSource(bindingList, null);
                gridFields.DataSource = source;
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void DisplayMessage(string message)
        {
            RadMessageBox.Show(this, message, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        private List<TableModel> GetSelectedNodes(bool isDestination)
        {
            List<TableModel> tableList = new List<TableModel>();

            try
            {
                /*
                var tree = isDestination ? treeDest : treeOrig;

                // Creamos la lista de origen
                foreach (RadTreeNode node in tree.Nodes)
                {
                    switch (node.CheckState)
                    {
                        case ToggleState.On:
                            // Add table and all columns
                            tableList.Add(new TableModel
                            {
                                TableName = node.Name,
                                Columns = node.Nodes
                                    .Select(column => column.Name)
                                    .ToList()
                            });
                            break;
                        case ToggleState.Indeterminate:
                            // Check all columns of this table
                            tableList.Add(new TableModel
                            {
                                TableName = node.Name,
                                Columns = node.Nodes
                                    .Where(w => w.CheckState == ToggleState.On)
                                    .Select(column => column.Name)
                                    .ToList()
                            });
                            break;
                        case ToggleState.Off:
                            // Ignoring
                            break;
                    }
                }
                */
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }

            return tableList;
        }

        #endregion

        #region Event methods
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<TableModel> tableListOrig = GetSelectedNodes(false);
            List<TableModel> tableListDest = GetSelectedNodes(true);

            // Send info about disable or not constraints
            result = Migrator.Generate(tableListOrig, tableListDest, false);
            btnExecute.Enabled = result.CanBeExecuted;
            txtResult.Text = result.Results.ToString();
        }

        private void btnExecute3333_Click(object sender, EventArgs e)
        {
            try
            {
                if (!result.CanBeExecuted) return;

                if (isProcessRunning)
                {
                    throw new Exception("A process is already running.");
                }

                btnExecute.Enabled = false;

                Thread backgroundThread = new Thread(() =>
                {
                    isProcessRunning = true;
                    string resultado = Migrator.ExecuteQuerys(result, progressBarResult);

                    txtResult.BeginInvoke(new Action(() =>
                    {
                        txtResult.Text = resultado;
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
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }
        #endregion

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
            LoadComboTables();
        }

        private void srcTableDropdown_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            var data = sender as RadDropDownList;
            if (data != null && data.SelectedValue != null)
            {
                LoadGridTable(data.SelectedValue.ToString());
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

        }
    }
}
