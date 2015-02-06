using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using NpgsqlTypes;
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
            catch (Exception)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException();
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
        public List<object> ExecuteQueryList(string pQuery)
        {
            try
            {
                List<object> data = new List<object>();
                // Conectar a la base de datos
                Connect();
                // Declare the parameter in the query string
                using (NpgsqlCommand command = new NpgsqlCommand(pQuery, conn))
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                data.Add(dr[i]);
                                Console.Write("{0} \t", dr[i]);
                            }
                        }
                    }
                }
                return data;
            }
            catch (Exception)
            {
                // Desconectar de la base de datos
                Disconnect();
                throw new PostgreSqlException();
            }
            finally
            {
                // Desconectar de la base de datos
                Disconnect();
            }
        }
        #endregion
    }
}
