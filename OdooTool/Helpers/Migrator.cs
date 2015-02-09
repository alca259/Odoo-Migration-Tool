using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostgreSQLConnect;
using PostgreSQLConnect.Models;

namespace OdooTool.Helpers
{
    /// <summary>
    /// Esta clase se encarga de generar el codigo SQL a traves
    /// de un DBLink para insertar datos
    /// </summary>
    public static class Migrator
    {
        public static QueryResult Generate(List<TableModel> orig, List<TableModel> dest)
        {
            QueryResult tablesResults = new QueryResult {CanBeExecuted = true};
            StringBuilder query = new StringBuilder();
            StringBuilder result = new StringBuilder();

            if (!orig.Any() || !dest.Any())
            {
                result.AppendLine("Nothing selected");
                tablesResults.Querys = query;
                tablesResults.Results = result;
                tablesResults.CanBeExecuted = false;
                return tablesResults;
            }

            // Obtenemos la configuracion para el origen
            SettingsModel modelSettings = SettingsManager.GetXml();
            if (modelSettings == null)
            {
                result.AppendLine("Settings not set");
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
                    result.AppendLine(string.Format("{0} - The table cannot be found in origin selected tables", destTable.TableName));
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
                    result.AppendLine(string.Format("{0} - The column {1} cannot be found in the origin selected table", destTable.TableName, columnNotFound));
                    tablesResults.CanBeExecuted = false;
                    continue;
                }

                // Obtenemos todos los tipos de las columnas a seleccionar
                IEnumerable<ColumnType> allColumnsAndTypes = manager.GetColumnsAndTypesForTable(destTable.TableName);
                // Las recorremos, si estan entre las que estamos buscando, las agregamos
                List<string> columnsAndTypes = allColumnsAndTypes.Where(c => destTable.Columns.Contains(c.Column)).OrderBy(o => o.Column).Select(columnType => columnType.ColumnAndType).ToList();

                // Generamos la consulta
                query.AppendLine(string.Format("INSERT INTO {0} (\"{1}\") SELECT \"{1}\" FROM DBLINK('{2}', 'SELECT \"{1}\" FROM {0}') AS T1 ({3})",
                destTable.TableName, string.Join("\", \"", destTable.Columns.OrderBy(o => o)), manager.GetConnectionStringForDbLink(), string.Join(", ", columnsAndTypes)));

                result.AppendLine(string.Format("{0} - Can be migrated", destTable.TableName));
            }

            tablesResults.Querys = query;
            tablesResults.Results = result;
            return tablesResults;
        }

        public static string ExecuteQuerys(StringBuilder querys)
        {
            StringBuilder results = new StringBuilder();

            // Obtenemos la configuracion
            SettingsModel model = SettingsManager.GetXml(true);
            if (model == null)
            {
                results.AppendLine("Settings are not setted");
                return results.ToString();
            }

            // Inicializamos el manager
            DatabaseManage manager = new DatabaseManage(model);

            foreach (string query in querys.ToString().Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(query)) continue;

                int startCut = query.IndexOf("INTO", StringComparison.Ordinal) + 5;
                int lengthCut = query.IndexOf("(", StringComparison.Ordinal) - startCut - 1; 

                string tableName = query.Substring(startCut, lengthCut);
                int rowsAffected = 0;

                try
                {
                    rowsAffected = manager.ExecuteCommand(query);
                    results.AppendLine(string.Format("{0} - Migrated OK - Rows inserted: {1}", tableName, rowsAffected));
                }
                catch (Exception ex)
                {
                    results.AppendLine(string.Format("{0} - Migrated Error - Rows inserted: {1} - Error: {2}", tableName, rowsAffected, ex.Message));
                }
            }

            return results.ToString();
        }
    }
}
