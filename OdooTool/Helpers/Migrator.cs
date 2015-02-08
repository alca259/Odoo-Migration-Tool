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
        public static string Generate(List<TableModel> orig, List<TableModel> dest)
        {
            if (!orig.Any() || !dest.Any()) return "Nothing selected";

            // Obtenemos la configuracion para el origen
            SettingsModel modelSettings = SettingsManager.GetXml();
            if (modelSettings == null)
                return "";

            // Inicializamos el manager
            DatabaseManage manager = new DatabaseManage(modelSettings);

            // Recorremos la lista de destino
            foreach (TableModel model in dest)
            {
                // Si el nombre de la tabla, no coincide con las de origen, continuamos
                if (!orig.Select(s => s.TableName.ToLower()).Contains(model.TableName.ToLower()))
                    continue;

                var tableOrig = orig.First(s => string.Equals(s.TableName, model.TableName));

                // Generamos la consulta
                StringBuilder query = new StringBuilder();

                List<string> columnsAndTypes = manager.GetColumnsAndTypesForTable(tableOrig.TableName);

                query.AppendLine(string.Format(@"
                INSERT INTO {0} ({1}) SELECT {2} FROM DBLINK('{3}', 'SELECT {2} FROM {4}') AS T1 ({5})",
                model.TableName, string.Join(", ", model.Columns), string.Join(", ", tableOrig.Columns),
                manager.GetConnectionString(), tableOrig.TableName, string.Join(", ", columnsAndTypes)));

                return query.ToString();
            }

            return "";
        }
    }
}
