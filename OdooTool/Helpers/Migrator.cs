using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostgreSQLConnect;
using PostgreSQLConnect.Models;
using Telerik.WinControls.UI;

namespace OdooTool.Helpers
{
    /// <summary>
    /// Esta clase se encarga de generar el codigo SQL a traves
    /// de un DBLink para insertar datos
    /// </summary>
    public static class Migrator
    {
        #region Common
        private static string GetTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        }
        #endregion

        #region Dblink generation & execution
        public static QueryResult Generate(List<TableModel> orig, List<TableModel> dest, bool disableConstraints)
        {
            QueryResult tablesResults = new QueryResult {CanBeExecuted = true};
            StringBuilder query = new StringBuilder();
            StringBuilder result = new StringBuilder();
            StringBuilder disableConstraintsQuery = new StringBuilder();
            StringBuilder enableConstraintsQuery = new StringBuilder();

            if (!orig.Any() || !dest.Any())
            {
                result.AppendLine(GetTime() + " - Nothing selected");
                tablesResults.Querys = query;
                tablesResults.Results = result;
                tablesResults.CanBeExecuted = false;
                return tablesResults;
            }

            // Obtenemos la configuracion para el origen
            SettingsModel modelSettings = SettingsManager.GetXml();
            if (modelSettings == null)
            {
                result.AppendLine(GetTime() + " - Settings not set");
                tablesResults.Querys = query;
                tablesResults.Results = result;
                tablesResults.CanBeExecuted = false;
                return tablesResults;
            }

            // Inicializamos el manager
            DatabaseManage manager = new DatabaseManage(modelSettings);

            // Recorremos la lista de destino
            foreach (TableModel destTable in dest)
            {
                // Si el nombre de la tabla, no coincide con las de origen, continuamos
                if (!orig.Select(s => s.TableName.ToLower()).Contains(destTable.TableName.ToLower()))
                {
                    result.AppendLine(string.Format("{0} - {1} - The table cannot be found in origin selected tables", GetTime(), destTable.TableName));
                    tablesResults.CanBeExecuted = false;
                    continue;
                }

                var tableOrig = orig.First(s => string.Equals(s.TableName, destTable.TableName));

                // Comprobamos si los campos de una tabla destino existen en la tabla de origen
                // Si uno de ellos no coincide, no continuamos
                bool continuar = true;
                string columnNotFound = "";
                foreach (string column in destTable.Columns.Where(column => !tableOrig.Columns.Contains(column.ToLower())))
                {
                    continuar = false;
                    columnNotFound = column;
                }

                if (!continuar)
                {
                    result.AppendLine(string.Format("{0} - {1} - The column {2} cannot be found in the origin selected table", GetTime(), destTable.TableName, columnNotFound));
                    tablesResults.CanBeExecuted = false;
                    continue;
                }

                // Generamos los comandos para des/habilitar las constraints, si asi se requiere
                if (disableConstraints)
                {
                    disableConstraintsQuery.AppendLine(string.Format("ALTER TABLE IF EXISTS {0} DISABLE TRIGGER ALL", destTable.TableName));
                    enableConstraintsQuery.AppendLine(string.Format("ALTER TABLE IF EXISTS {0} ENABLE TRIGGER ALL", destTable.TableName));
                }

                // Obtenemos todos los tipos de las columnas a seleccionar
                IEnumerable<ColumnType> allColumnsAndTypes = manager.GetColumnsAndTypesForTable(destTable.TableName);
                // Las recorremos, si estan entre las que estamos buscando, las agregamos
                List<string> columnsAndTypes = allColumnsAndTypes.Where(c => destTable.Columns.Contains(c.Column)).OrderBy(o => o.Column).Select(columnType => columnType.ColumnAndType).ToList();

                // Generamos la consulta
                query.AppendLine(string.Format("INSERT INTO {0} (\"{1}\") SELECT \"{1}\" FROM DBLINK('{2}', 'SELECT \"{1}\" FROM {0}') AS T1 ({3})",
                destTable.TableName, string.Join("\", \"", destTable.Columns.OrderBy(o => o)), manager.GetConnectionStringForDbLink(), string.Join(", ", columnsAndTypes)));

                result.AppendLine(string.Format("{0} - {1} - Can be migrated", GetTime(), destTable.TableName));
                tablesResults.NumberOfItems++;
            }

            tablesResults.Querys = query;
            tablesResults.Results = result;
            tablesResults.DisableConstraints = disableConstraints;
            tablesResults.QuerysDisableConstraints = disableConstraintsQuery;
            tablesResults.QuerysEnableConstraints = enableConstraintsQuery;
            return tablesResults;
        }

        public static string ExecuteQuerys(QueryResult result, RadProgressBar progressBarResult)
        {
            StringBuilder results = new StringBuilder();

            // Obtenemos la configuracion
            SettingsModel model = SettingsManager.GetXml(true);
            if (model == null)
            {
                results.AppendLine(GetTime() + " - Settings are not setted");
                return results.ToString();
            }

            // Inicializamos el manager
            DatabaseManage manager = new DatabaseManage(model);

            // Si tenemos que deshabilitar constraints
            if (result.DisableConstraints)
            {
                foreach (string query in result.QuerysDisableConstraints.ToString().Split('\n'))
                {
                    if (string.IsNullOrWhiteSpace(query)) continue;

                    int startCut = query.IndexOf("EXISTS", StringComparison.Ordinal) + 7;
                    int lengthCut = query.IndexOf("DISABLE", StringComparison.Ordinal) - startCut - 1;

                    string tableName = query.Substring(startCut, lengthCut);

                    try
                    {
                        manager.ExecuteCommand(query);
                        results.AppendLine(string.Format("{0} - Disabling constraints for table {1} - Disabled", GetTime(), tableName));
                    }
                    catch (Exception ex)
                    {
                        results.AppendLine(string.Format("{0} - Disabling constraints for table {1} - Cannot be disabled - Error: {2}", GetTime(), tableName, ex.Message));
                    }
                }
            }

            int currentNumberTable = 0;

            foreach (string query in result.Querys.ToString().Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(query)) continue;

                int startCut = query.IndexOf("INTO", StringComparison.Ordinal) + 5;
                int lengthCut = query.IndexOf("(", StringComparison.Ordinal) - startCut - 1; 

                string tableName = query.Substring(startCut, lengthCut);
                int rowsAffected = 0;

                try
                {
                    rowsAffected = manager.ExecuteCommand(query);
                    results.AppendLine(string.Format("{0} - {1} - Migrated OK - Rows inserted: {2}", GetTime(), tableName, rowsAffected));
                }
                catch (Exception ex)
                {
                    results.AppendLine(string.Format("{0} - {1} - Migrated Error - Rows inserted: {2} - Error: {3}", GetTime(), tableName, rowsAffected, ex.Message));
                }

                currentNumberTable++;

                int table = currentNumberTable;
                progressBarResult.BeginInvoke(new Action(() =>
                {
                    int newValue = (int)(((float)table / result.NumberOfItems) * 100);
                    if (newValue > 100)
                    {
                        newValue = 100;
                    }
                    progressBarResult.Value1 = newValue;
                }));
            }

            // Si tenemos que habilitar constraints
            if (result.DisableConstraints)
            {
                foreach (string query in result.QuerysEnableConstraints.ToString().Split('\n'))
                {
                    if (string.IsNullOrWhiteSpace(query)) continue;

                    int startCut = query.IndexOf("EXISTS", StringComparison.Ordinal) + 7;
                    int lengthCut = query.IndexOf("ENABLE", StringComparison.Ordinal) - startCut - 1;

                    string tableName = query.Substring(startCut, lengthCut);

                    try
                    {
                        manager.ExecuteCommand(query);
                        results.AppendLine(string.Format("{0} - Enabling constraints for table {1} - Enabled", GetTime(), tableName));
                    }
                    catch (Exception ex)
                    {
                        results.AppendLine(string.Format("{0} - Enabling constraints for table {1} - Cannot be enabled - Error: {2}", GetTime(), tableName, ex.Message));
                    }
                }
            }

            return results.ToString();
        }
        #endregion

        #region Inserts generation & execution
        public static string ToggleContraints(IEnumerable<string> tableList, bool enable = false)
        {
            StringBuilder results = new StringBuilder();

            // Obtenemos la configuracion
            SettingsModel model = SettingsManager.GetXml(true);
            if (model == null)
            {
                results.AppendLine(GetTime() + "Settings are not setted");
                return results.ToString();
            }

            // Inicializamos el manager
            DatabaseManage manager = new DatabaseManage(model);

            foreach (string table in tableList)
            {
                string query = string.Format(enable ?
                    "ALTER TABLE IF EXISTS {0} ENABLE TRIGGER ALL" :
                    "ALTER TABLE IF EXISTS {0} DISABLE TRIGGER ALL", table);

                string mode = enable ? "Enabling" : "Disabling";
                string action = enable ? "Enabled" : "Disabled";

                if (string.IsNullOrWhiteSpace(query)) continue;

                try
                {
                    manager.ExecuteCommand(query);
                    results.AppendLine(string.Format("{0} - {1} constraints for table {2} - {3}", GetTime(), mode, table, action));
                }
                catch (Exception ex)
                {
                    results.AppendLine(string.Format("{0} - {1} constraints for table {2} - Cannot be {3} - Error: {4}", GetTime(), mode, table, action, ex.Message));
                }
            }

            return results.ToString();
        }

        public static List<FieldResult> GenerateInserts(string pTableName, List<ColumnData> pValidColumns,
            DatabaseManage origManager, DatabaseManage destManager, RadProgressBar progressBarResult)
        {
            List<FieldResult> results = new List<FieldResult>();
            List<RowModel> dataOrig;
            List<RowModel> dataDest;

            // Obtenemos todos los datos de origen de la tabla
            if (pValidColumns.Select(s => s.ColumnName).Contains("id"))
            {
                dataOrig = origManager.ExecuteQueryList(string.Format("SELECT \"{0}\" FROM {1} ORDER BY id ASC",
                    string.Join("\", \"", pValidColumns.Select(s => s.ColumnName).OrderBy(o => o)), pTableName), pValidColumns);

                // Obtenemos todos los datos de destino de la tabla
                dataDest = destManager.ExecuteQueryList(string.Format("SELECT \"{0}\" FROM {1} ORDER BY id ASC",
                    string.Join("\", \"", pValidColumns.Select(s => s.ColumnName).OrderBy(o => o)), pTableName), pValidColumns);
            }
            else
            {
                dataOrig = origManager.ExecuteQueryList(string.Format("SELECT \"{0}\" FROM {1}",
                    string.Join("\", \"", pValidColumns.Select(s => s.ColumnName).OrderBy(o => o)), pTableName), pValidColumns);

                // Obtenemos todos los datos de destino de la tabla
                dataDest = destManager.ExecuteQueryList(string.Format("SELECT \"{0}\" FROM {1}",
                    string.Join("\", \"", pValidColumns.Select(s => s.ColumnName).OrderBy(o => o)), pTableName), pValidColumns);
            }

            int rowCount = dataOrig.Count();
            int rowIndex = 0;

            foreach (RowModel row in dataOrig)
            {
                StringBuilder builderQuery = new StringBuilder();

                // Generamos la query
                builderQuery.Append(string.Format("INSERT INTO {0} (\"{1}\") VALUES (", pTableName,
                    string.Join("\", \"", pValidColumns.Select(s => s.ColumnName).OrderBy(o => o))));

                int fieldCount = row.Fields.Count;
                int idx = 1;
                foreach (var fieldValue in row.Fields)
                {
                    if ("null".Equals(fieldValue))
                    {
                        builderQuery.Append(idx < fieldCount ? "null, " : "null");
                    }
                    else
                    {
                        builderQuery.Append(idx < fieldCount ? string.Format("'{0}', ", fieldValue) : string.Format("'{0}'", fieldValue));
                    }
                    idx++;
                }
                builderQuery.AppendLine(")");

                // Generamos el identificador a devolver
                FieldResult rowResult = new FieldResult
                {
                    Id = row.Id,
                    Name = row.Name,
                    Query = builderQuery.ToString(),
                    Migrate = true
                };

                // Si ya existe un registro con el mismo identificador, automáticamente lo desmarcamos
                if (dataDest.Any(w => w.Id == row.Id) && row.Id > 0)
                {
                    rowResult.Migrate = false;
                }

                results.Add(rowResult);

                rowIndex++;
                progressBarResult.BeginInvoke(new Action(() =>
                {
                    int newValue = (int)(((float)rowIndex / rowCount) * 100);
                    if (newValue > 100)
                    {
                        newValue = 100;
                    }
                    progressBarResult.Value1 = newValue;
                }));
            }

            return results;
        }

        public static string ExecuteInserts(QueryResult querys, RadProgressBar progressBarResult)
        {
            StringBuilder results = new StringBuilder();

            // Obtenemos la configuracion
            SettingsModel model = SettingsManager.GetXml(true);
            if (model == null)
            {
                results.AppendLine(GetTime() + " - Settings are not setted");
                return results.ToString();
            }

            // Inicializamos el manager
            DatabaseManage manager = new DatabaseManage(model);

            int currentNumberRow = 0;
            int rowsAffected = 0;

            results.AppendLine(string.Format("{0} - Starting migration", GetTime()));

            foreach (string query in querys.Querys.ToString().Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(query)) continue;

                try
                {
                    manager.ExecuteCommand(query);
                    rowsAffected++;
                }
                catch (Exception ex)
                {
                    results.AppendLine(string.Format("{0} - Migrating error - Current query: {1} - Error: {2}", GetTime(), query, ex.Message));
                }

                currentNumberRow++;

                progressBarResult.BeginInvoke(new Action(() =>
                {
                    int newValue = (int)(((float)currentNumberRow / querys.NumberOfItems) * 100);
                    if (newValue > 100)
                    {
                        newValue = 100;
                    }
                    progressBarResult.Value1 = newValue;
                }));
            }
            results.AppendLine(results.Length == 0
                ? string.Format("{0} - Migrated OK - Rows inserted: {1}", GetTime(), rowsAffected)
                : string.Format("{0} - Migrated with Errors - Rows inserted: {1}", GetTime(), rowsAffected));

            return results.ToString();
        }
        
        #endregion

        #region Execution sequences
        public static void ExecuteSequences(List<string> querys, RadProgressBar progressBarResult)
        {
            // Obtenemos la configuracion
            SettingsModel model = SettingsManager.GetXml(true);
            if (model == null)
            {
                return;
            }

            // Inicializamos el manager
            DatabaseManage manager = new DatabaseManage(model);

            int currentNumberSeq = 0;
            int numSequences = querys.Count();

            foreach (string query in querys)
            {
                if (string.IsNullOrWhiteSpace(query)) continue;

                manager.ExecuteCommand(query);

                currentNumberSeq++;
                progressBarResult.BeginInvoke(new Action(() =>
                {
                    int newValue = (int)(((float)currentNumberSeq / numSequences) * 100);
                    if (newValue > 100)
                    {
                        newValue = 100;
                    }
                    progressBarResult.Value1 = newValue;
                }));
            }
        }
        #endregion
    }
}
