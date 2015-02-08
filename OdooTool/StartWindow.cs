using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OdooTool.Helpers;
using PostgreSQLConnect;
using PostgreSQLConnect.Models;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace OdooTool
{
    public partial class StartWindow : RadForm
    {
        private QueryResult result { get; set; }

        public StartWindow()
        {
            InitializeComponent();
            SettingsManager.Initialize();
            result = new QueryResult();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }

        private void loadSourceTables_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Obtenemos la configuracion
                SettingsModel model = SettingsManager.GetXml();
                if (model == null)
                    return;

                // Limpiamos el arbol
                treeOrig.Nodes.Clear();

                // Inicializamos el manager
                DatabaseManage manager = new DatabaseManage(model);

                // Obtenemos las tablas
                IEnumerable<string> tables = manager.GetTables();
                foreach (string table in tables)
                {
                    // Buscamos el numero de filas
                    string numRows = manager.GetRowsForTable(table);

                    // Agregamos la tabla al arbol
                    RadTreeNode tableNode = treeOrig.Nodes.Add(table, string.Format("{0} ({1})", table, numRows), "");

                    // Obtenemos las columnas de la tabla
                    IEnumerable<string> columns = manager.GetColumnsForTable(table);
                    foreach (string column in columns)
                    {
                        // Agregamos la columna al nodo de la tabla
                        tableNode.Nodes.Add(column);
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void loadDestinationTables_Click(object sender, System.EventArgs e)
        {
            try 
            { 
                // Obtenemos la configuracion
                SettingsModel model = SettingsManager.GetXml(true);
                if (model == null)
                    return;

                // Limpiamos el arbol
                treeDest.Nodes.Clear();

                // Inicializamos el manager
                DatabaseManage manager = new DatabaseManage(model);

                // Obtenemos las tablas
                IEnumerable<string> tables = manager.GetTables();
                foreach (string table in tables)
                {
                    // Buscamos el numero de filas
                    string numRows = manager.GetRowsForTable(table);

                    // Agregamos la tabla al arbol
                    RadTreeNode tableNode = treeDest.Nodes.Add(table, string.Format("{0} ({1})", table, numRows), "");

                    // Obtenemos las columnas de la tabla
                    IEnumerable<string> columns = manager.GetColumnsForTable(table);
                    foreach (string column in columns)
                    {
                        // Agregamos la columna al nodo de la tabla
                        tableNode.Nodes.Add(column);
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

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

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            try
            {
                List<TableModel> tableListOrig = new List<TableModel>();
                List<TableModel> tableListDest = new List<TableModel>();

                // Creamos la lista de origen
                foreach (RadTreeNode node in treeOrig.Nodes)
                {
                    switch (node.CheckState)
                    {
                        case ToggleState.On:
                            // Add table and all columns
                            tableListOrig.Add(new TableModel
                            {
                                TableName = node.Name,
                                Columns = node.Nodes
                                    .Select(column => column.Name)
                                    .ToList()
                            });
                            break;
                        case ToggleState.Indeterminate:
                            // Check all columns of this table
                            tableListOrig.Add(new TableModel
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

                // Creamos la lista de destino
                foreach (RadTreeNode node in treeDest.Nodes)
                {
                    switch (node.CheckState)
                    {
                        case ToggleState.On:
                            // Add table and all columns
                            tableListDest.Add(new TableModel
                            {
                                TableName = node.Name,
                                Columns = node.Nodes
                                    .Select(column => column.Name)
                                    .ToList()
                            });
                            break;
                        case ToggleState.Indeterminate:
                            // Check all columns of this table
                            tableListDest.Add(new TableModel
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

                result = Migrator.Generate(tableListOrig, tableListDest);
                btnExecute.Enabled = result.CanBeExecuted;
                btnCopy.Enabled = result.CanBeExecuted;
                txtResult.Text = result.Results.ToString();
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void btnExecute_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!result.CanBeExecuted) return;
                txtResult.Text = Migrator.ExecuteQuerys(result.Querys);
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void treeOrig_NodeCheckedChanged(object sender, TreeNodeCheckedEventArgs e)
        {
            result.CanBeExecuted = false;
            btnExecute.Enabled = false;
            btnCopy.Enabled = false;
        }

        private void treeDest_NodeCheckedChanged(object sender, TreeNodeCheckedEventArgs e)
        {
            result.CanBeExecuted = false;
            btnExecute.Enabled = false;
            btnCopy.Enabled = false;
        }

        private void DisplayMessage(string message)
        {
            RadMessageBox.Show(this, message, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result.Querys.ToString());
        }
    }
}
