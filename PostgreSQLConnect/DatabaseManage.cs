using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using PostgreSQLConnect.Exceptions;
using PostgreSQLConnect.Models;

namespace PostgreSQLConnect
{
    public class DatabaseManage
    {
        #region Vars
        private string Host { get; set; }
        private int Port { get; set; }
        private string User { get; set; }
        private string Password { get; set; }
        private string Database { get; set; }
        NpgsqlConnection conn { get; set; }
        #endregion

        #region Constructors
        public DatabaseManage(string pHost, int pPort, string pUser, string pPassword, string pDatabase)
        {
            Host = pHost;
            Port = pPort;
            User = pUser;
            Password = pPassword;
            Database = pDatabase;
        }

        public DatabaseManage(SettingsModel settings)
        {
            Host = settings.Host;
            Port = settings.Port;
            User = settings.User;
            Password = settings.Password;
            Database = settings.Database;
        }
        #endregion

        #region Public Methods

        #region Connection methods
        private string GetConnectionString()
        {
            return string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", Host, Port, User, Password, Database);
        }

        public string GetConnectionStringForDbLink()
        {
            return string.Format("hostaddr={0} port={1} dbname={4} user={2} password={3}", Host, Port, User, Password, Database);
        }

        /// <summary>
        /// Establece una sesión con el servidor de base de datos
        /// </summary>
        private void Connect()
        {
            try
            {
                conn = new NpgsqlConnection(GetConnectionString());
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new PostgreSqlException(string.Format("Cannot connect to PostgreSQL ({0})", ex.Message), ex);
            }
        }

        /// <summary>
        /// Desconecta una sesión con el servidor de base de datos
        /// </summary>
        private void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new PostgreSqlException(string.Format("Cannot disconnect to PostgreSQL ({0})", ex.Message), ex);
            }
        }
        #endregion

        #region Read methods
        /// <summary>
        /// Ejecuta una consulta y devuelve un dataset
        /// </summary>
        /// <param name="pQuery">String query</param>
        /// <returns>Dataset</returns>
        public DataSet ExecuteQueryDataset(string pQuery)
        {
            // Cargamos el dataset
            DataSet ds = new DataSet();
            try
            {
                // Conectar a la base de datos
                Connect();
                // Realizamos la peticion
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(pQuery, conn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
            // Devolvemos el dataset
            return ds;
        }

        /// <summary>
        /// Ejecuta una consulta y devuelve una lista de objetos
        /// </summary>
        /// <param name="pQuery">String query</param>
        /// <returns>Lista de objetos</returns>
        public List<RowModel> ExecuteQueryList(string pQuery)
        {
            List<RowModel> data = new List<RowModel>();
            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                using (NpgsqlCommand command = new NpgsqlCommand(pQuery, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            List<string> fieldData = new List<string>();

                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                fieldData.Add(dr[i].ToString());
                            }

                            string nameRow;
                            string idRow;

                            try
                            {
                                idRow = dr["id"].ToString();
                            }
                            catch(Exception)
                            {
                                idRow = "0";
                            }

                            try
                            {
                                nameRow = dr["name"].ToString();
                            }
                            catch(Exception)
                            {
                                nameRow = "";
                            }

                            data.Add(new RowModel { Fields = fieldData, Id = Convert.ToInt32(idRow), Name = nameRow });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
            return data;
        }
        #endregion

        #region Write methods

        public int ExecuteCommand(string sql)
        {
            // Vars
            int rowsAffected = 0;

            try
            {
                // Conectar a la base de datos
                Connect();

                // Preparamos la consulta
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                
                // Realizamos la peticion
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }

            return rowsAffected;
        }
        #endregion

        #region Information schema
        /// <summary>
        /// Devuelve las tablas de una base de datos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetTables()
        {
            List<string> data = new List<string>();
            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                using (NpgsqlCommand command = new NpgsqlCommand(string.Format(@"
                SELECT table_name
                FROM information_schema.tables
                WHERE    table_schema = 'public' 
                    AND table_catalog = '{0}'
                    AND table_type = 'BASE TABLE'
                ORDER BY table_name", Database), conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            data.Add(dr[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
            return data;
        }

        /// <summary>
        /// Devuelve booleano si encuentra la tabla suministrada por parametro
        /// </summary>
        /// <returns></returns>
        public bool GetTableWithName(string pTableName)
        {
            bool result = false;
            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                using (NpgsqlCommand command = new NpgsqlCommand(string.Format(@"
                SELECT table_name
                FROM information_schema.tables
                WHERE    table_schema = 'public' 
                    AND table_catalog = '{0}'
                    AND table_name = '{1}'
                    AND table_type = 'BASE TABLE'
                ORDER BY table_name", Database, pTableName), conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
            return result;
        }

        /// <summary>
        /// Devuelve las columnas de una tabla
        /// </summary>
        /// <param name="pTable"></param>
        /// <returns></returns>
        public IEnumerable<string> GetColumnsForTable(string pTable)
        {
            List<string> data = new List<string>();
            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                string querySql = string.Format(@"
                SELECT column_name
                FROM information_schema.columns
                WHERE table_name   = '{0}'
                ORDER BY column_name", pTable);

                using (NpgsqlCommand command = new NpgsqlCommand(querySql, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            data.Add(dr[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
            return data;
        }

        /// <summary>
        /// Busca una columna en una tabla, devuelve booleano
        /// </summary>
        /// <param name="pTable"></param>
        /// <param name="pColumnName"></param>
        /// <returns></returns>
        public bool GetColumnWithNameForTable(string pTable, string pColumnName)
        {
            bool result = false;
            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                string querySql = string.Format(@"
                SELECT column_name
                FROM information_schema.columns
                WHERE table_name   = '{0}'
                AND column_name    = '{1}'
                ORDER BY column_name", pTable, pColumnName);

                using (NpgsqlCommand command = new NpgsqlCommand(querySql, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
            return result;
        }

        /// <summary>
        /// Devuelve las columnas de una tabla con su tipo
        /// </summary>
        /// <param name="pTable"></param>
        /// <returns></returns>
        public IEnumerable<ColumnType> GetColumnsAndTypesForTable(string pTable)
        {
            List<ColumnType> data = new List<ColumnType>();
            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                string querySql = string.Format(@"
                SELECT column_name, 
                   CASE 
                    WHEN data_type = 'character varying' AND character_maximum_length is not null THEN
                     column_name||' '||data_type||'('||character_maximum_length||')'
                    WHEN data_type = 'character varying' AND character_octet_length is not null THEN
                     column_name||' '||data_type
                   ELSE
                    column_name||' '||data_type
                  END as " + '"' + "Columnas de la tabla" + '"' + @"
                FROM information_schema.columns
                WHERE table_name   = '{0}'", pTable);

                using (NpgsqlCommand command = new NpgsqlCommand(querySql, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            data.Add(new ColumnType
                            {
                                Column = dr[0].ToString(),
                                ColumnAndType = dr[1].ToString()
                            });
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
            return data;
        }

        /// <summary>
        /// Devuelve el numero de filas que habia la ultima vez que se realizo
        /// un analisis de la base de datos
        /// </summary>
        /// <param name="pTable"></param>
        /// <returns></returns>
        public string GetRowsForTable(string pTable)
        {
            // Vars
            string result = "0";

            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                string querySql = string.Format(@"
                SELECT n_live_tup 
                FROM pg_stat_user_tables 
                WHERE relname = '{0}'", pTable);

                using (NpgsqlCommand command = new NpgsqlCommand(querySql, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result = dr[0].ToString();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }

            return result;
        }

        /// <summary>
        /// Devuelve el numero de filas actuales en una tabla
        /// </summary>
        /// <param name="pTable"></param>
        /// <returns></returns>
        public string GetCurrentRowsForTable(string pTable)
        {
            // Vars
            string result = "0";

            try
            {
                // Conectar a la base de datos
                Connect();

                // Declare the parameter in the query string
                string querySql = string.Format("SELECT count(1) FROM {0}", pTable);

                using (NpgsqlCommand command = new NpgsqlCommand(querySql, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result = dr[0].ToString();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException(ex.Message, ex);
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }

            return result;
        }
        #endregion

        #endregion
    }
}
