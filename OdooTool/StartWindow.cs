using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OdooTool.Helpers;
using PostgreSQLConnect;
using PostgreSQLConnect.Models;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace OdooTool
{
    public partial class StartWindow : RadForm
    {
        public StartWindow()
        {
            InitializeComponent();
            SettingsManager.Initialize();
        }

        private void loadSourceTables_Click(object sender, System.EventArgs e)
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
            List<string> tables = manager.GetTables();
            foreach (string table in tables)
            {
                // Agregamos la tabla al arbol
                RadTreeNode tableNode = treeOrig.Nodes.Add(table);
                
                // Obtenemos las columnas de la tabla
                List<string> columns = manager.GetColumnsForTable(table);
                foreach (string column in columns)
                {
                    // Agregamos la columna al nodo de la tabla
                    tableNode.Nodes.Add(column);
                }
            }
        }

        private void loadDestinationTables_Click(object sender, System.EventArgs e)
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
            List<string> tables = manager.GetTables();
            foreach (string table in tables)
            {
                // Agregamos la tabla al arbol
                RadTreeNode tableNode = treeDest.Nodes.Add(table);

                // Obtenemos las columnas de la tabla
                List<string> columns = manager.GetColumnsForTable(table);
                foreach (string column in columns)
                {
                    // Agregamos la columna al nodo de la tabla
                    tableNode.Nodes.Add(column);
                }
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
                            TableName = node.Value.ToString(),
                            Columns = node.Nodes
                                .Select(column => column.Value.ToString())
                                .ToList()
                        });
                        break;
                    case ToggleState.Indeterminate:
                        // Check all columns of this table
                        tableListOrig.Add(new TableModel
                        {
                            TableName = node.Value.ToString(),
                            Columns = node.Nodes
                                .Where(w => w.CheckState == ToggleState.On)
                                .Select(column => column.Value.ToString())
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
                            TableName = node.Value.ToString(),
                            Columns = node.Nodes
                                .Select(column => column.Value.ToString())
                                .ToList()
                        });
                        break;
                    case ToggleState.Indeterminate:
                        // Check all columns of this table
                        tableListDest.Add(new TableModel
                        {
                            TableName = node.Value.ToString(),
                            Columns = node.Nodes
                                .Where(w => w.CheckState == ToggleState.On)
                                .Select(column => column.Value.ToString())
                                .ToList()
                        });
                        break;
                    case ToggleState.Off:
                        // Ignoring
                        break;
                }
            }

            txtResult.Text = Migrator.Generate(tableListOrig, tableListDest);
        }
    }
}
