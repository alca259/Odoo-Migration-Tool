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
        #region Properties
        private QueryResult result { get; set; }
        #endregion

        #region Constructor
        public StartWindow()
        {
            InitializeComponent();
            SettingsManager.Initialize();
            result = new QueryResult();
            RadMessageBox.SetThemeName("VisualStudio2012Light");
        }
        #endregion

        #region Private methods

        private void LoadTable(bool isDestination)
        {
            try
            {
                // Obtenemos la configuracion
                SettingsModel model = SettingsManager.GetXml(isDestination);
                if (model == null)
                    return;

                // Limpiamos el arbol
                if (isDestination)
                {
                    treeDest.Nodes.Clear();
                }
                else
                {
                    treeOrig.Nodes.Clear();
                }

                // Inicializamos el manager
                DatabaseManage manager = new DatabaseManage(model);

                // Obtenemos las tablas
                IEnumerable<string> tables = manager.GetTables();
                foreach (string table in tables)
                {
                    // Buscamos el numero de filas
                    string numRows = manager.GetRowsForTable(table);

                    // Agregamos la tabla al arbol
                    RadTreeNode tableNode = isDestination ?
                        treeDest.Nodes.Add(table, string.Format("{0} ({1})", table, numRows), "") :
                        treeOrig.Nodes.Add(table, string.Format("{0} ({1})", table, numRows), "");

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
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }

            return tableList;
        }

        private void CheckUncheckOrig(RadTreeNode currentNode)
        {
            RadTreeNode foundNode;
            RadTreeNode currentParentNode;

            // Determinar si el nodo actual es un campo o una tabla
            if (currentNode.Parent == null)
            {
                // Tabla
                // Buscamos la tabla en los nodos del arbol de origen
                foundNode = treeOrig.Nodes.SingleOrDefault(a => a.Name.ToLower() == currentNode.Name.ToLower());
                currentParentNode = currentNode;
            }
            else
            {
                // Campo
                foundNode = treeOrig.Nodes.SingleOrDefault(a => a.Name.ToLower() == currentNode.Parent.Name.ToLower());
                currentParentNode = currentNode.Parent;
            }

            if (foundNode == null)
                return;

            switch (currentParentNode.CheckState)
            {
                case ToggleState.On:
                    // Add table and all columns
                    foundNode.CheckState = ToggleState.On;
                    foreach (RadTreeNode childFoundNode in foundNode.Nodes)
                    {
                        childFoundNode.CheckState = ToggleState.On;
                    }
                    break;
                case ToggleState.Indeterminate:
                    // Check only column of current node
                    // Looking for child on found node
                    foreach (RadTreeNode childFoundNode in foundNode.Nodes.Where(childFoundNode => currentNode.Name.ToLower() == childFoundNode.Name.ToLower()))
                    {
                        childFoundNode.CheckState = currentNode.CheckState;
                    }
                    break;
                case ToggleState.Off:
                    // Remove table and all columns
                    foundNode.CheckState = ToggleState.Off;
                    foreach (RadTreeNode childFoundNode in foundNode.Nodes)
                    {
                        childFoundNode.CheckState = ToggleState.Off;
                    }
                    break;
            }
        }

        #endregion

        #region Event methods
        private void loadSourceTables_Click(object sender, System.EventArgs e)
        {
            LoadTable(false);
        }

        private void loadDestinationTables_Click(object sender, System.EventArgs e)
        {
            LoadTable(true);
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
            List<TableModel> tableListOrig = GetSelectedNodes(false);
            List<TableModel> tableListDest = GetSelectedNodes(true);

            result = Migrator.Generate(tableListOrig, tableListDest);
            btnExecute.Enabled = result.CanBeExecuted;
            btnCopy.Enabled = result.CanBeExecuted;
            txtResult.Text = result.Results.ToString();
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

            CheckUncheckOrig(e.Node);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result.Querys.ToString());
        }
        #endregion
    }
}
