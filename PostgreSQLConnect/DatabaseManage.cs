using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using PostgreSQLConnect.Exceptions;

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
        #endregion

        #region Private Methods
        private string GetConnectionString()
        {
            return string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", Host, Port, User, Password, Database);
        }
        #endregion

        #region Public Methods

        #region Connection methods
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
                throw new PostgreSqlException("Cannot connect to PostgreSQL", ex);
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
                throw new PostgreSqlException("Cannot disconnect to PostgreSQL", ex);
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
            try
            {
                // Conectar a la base de datos
                Connect();
                // Realizamos la peticion
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(pQuery, conn);
                // Cargamos el dataset
                DataSet ds = new DataSet();
                da.Fill(ds);
                // Devolvemos el dataset
                return ds;
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
        }

        /// <summary>
        /// Ejecuta una consulta y devuelve una lista de objetos
        /// </summary>
        /// <param name="pQuery">String query</param>
        /// <returns>Lista de objetos</returns>
        public List<List<string>> ExecuteQueryList(string pQuery)
        {
            try
            {
                List<List<string>> data = new List<List<string>>();
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

                            data.Add(fieldData);
                        }
                    }
                }
                return data;
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
        }
        #endregion

        #region Information schema
        /// <summary>
        /// Devuelve las tablas de una base de datos
        /// </summary>
        /// <returns></returns>
        public List<object> GetTables()
        {
            try
            {
                List<object> data = new List<object>();
                // Conectar a la base de datos
                Connect();
                // Declare the parameter in the query string
                using (NpgsqlCommand command = new NpgsqlCommand(string.Format(@"
                SELECT table_name
                FROM information_schema.tables
                WHERE    table_schema = 'public' 
                    AND table_catalog = '{0}'
                    AND table_type = 'BASE TABLE'", Database), conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                data.Add(dr[i]);
                            }
                        }
                    }
                }
                return data;
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
        }

        /// <summary>
        /// Devuelve las columnas de una tabla con su tipo
        /// </summary>
        /// <param name="pTable"></param>
        /// <returns></returns>
        public List<object> GetColumnsForTable(string pTable)
        {
            try
            {
                List<object> data = new List<object>();
                // Conectar a la base de datos
                Connect();
                // Declare the parameter in the query string

                string querySql = string.Format(@"
                SELECT
                   CASE 
                    WHEN data_type = 'character varying' AND character_maximum_length is not null THEN
                     column_name||' '||data_type||'('||character_maximum_length||'),'
                    WHEN data_type = 'character varying' AND character_octet_length is not null THEN
                     column_name||' '||data_type||','
                   ELSE
                    column_name||' '||data_type||','
                  END as " + '"' + "Columnas de la tabla" + '"' + @"
                FROM information_schema.columns
                WHERE table_name   = '{0}'", pTable);

                using (NpgsqlCommand command = new NpgsqlCommand(querySql, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                data.Add(dr[i]);
                            }
                        }
                    }
                }
                return data;
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
        }
        #endregion

        #endregion
    }
}
