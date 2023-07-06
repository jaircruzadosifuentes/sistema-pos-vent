using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaPersistencia.Mysql
{
    public class GestorDaoMysql
    {
        private MySqlConnection connection;
        private MySqlTransaction transaccion;

        public void connectionOpen()
        {
            try
            {
                connection = new MySqlConnection
                {
                    //ConnectionString = "Server=216.246.112.66;Port=3306;Database=jkdldrlr_pancanela;UserId=jkdldrlr_lawcodev;Password=VXg6EBRF3c@d;persistsecurityinfo=True;"
                    ConnectionString = "datasource=127.0.0.1;port=3306;username=jaircruzado;password=@Jcs12344321-lw;database=bd_pan_canela"
                };
                connection.Open();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void connectionClose()
        {
            try
            {
                connection.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al cerrar la conexión con la Base de Datos.", err);
            }
        }

        public void startTransaction()
        {
            try
            {
                connectionOpen();
                transaccion = connection.BeginTransaction();
            }
            catch (Exception err)
            {
                throw new Exception("Error al iniciar la transacción con la Base de Datos.", err);
            }
        }

        public void finishTransaction()
        {
            try
            {
                transaccion.Commit();
                connection.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al terminar la transacción con la Base de Datos.", err);
            }
        }

        public void cancelTransaction()
        {
            try
            {
                transaccion.Rollback();
                connection.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al cancelar la transacción con la Base de Datos.", err);
            }
        }

        public MySqlDataReader runQuery(String sentenciaMySQL)
        {
            try
            {
                MySqlCommand comandoMySQL = connection.CreateCommand();
                if (transaccion != null)
                    comandoMySQL.Transaction = transaccion;
                comandoMySQL.CommandText = sentenciaMySQL;
                comandoMySQL.CommandType = CommandType.Text;
                return comandoMySQL.ExecuteReader();
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar consulta en la Base de Datos.", err);
            }
        }

        public MySqlCommand getCommandMysql(String sentenciaMySQL)
        {
            try
            {
                MySqlCommand comandoMySQL = connection.CreateCommand();
                if (transaccion != null)
                    comandoMySQL.Transaction = transaccion;
                comandoMySQL.CommandText = sentenciaMySQL;
                comandoMySQL.CommandType = CommandType.Text;
                return comandoMySQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }
        public MySqlCommand getCommandProcedure(MySqlCommand procedimientoAlmacenado)
        {
            try
            {
                MySqlCommand comandoMySQL = connection.CreateCommand();
                if (transaccion != null)
                    comandoMySQL.Transaction = transaccion;
                comandoMySQL.CommandText = procedimientoAlmacenado.CommandText;
                comandoMySQL.CommandType = CommandType.StoredProcedure;
                return comandoMySQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }

        public MySqlDataReader runCommandProcedureSp(MySqlCommand procedimientoAlmacenado)
        {
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                MySqlCommand comandoMySQL = connection.CreateCommand();
                if (transaccion != null)
                    comandoMySQL.Transaction = transaccion;
                comandoMySQL.CommandText = procedimientoAlmacenado.CommandText;
                comandoMySQL.Parameters.AddRange(parameters.ToArray());
                comandoMySQL.CommandType = CommandType.StoredProcedure;
                var resultado = comandoMySQL.ExecuteReader();
                return resultado;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }

        public MySqlDataReader runCommandoProcedureSpParamater(MySqlCommand procedimientoAlmacenado, List<MySqlParameter> parametros)
        {
            try
            {
                MySqlCommand comandoMySQL = connection.CreateCommand();
                if (transaccion != null)
                    comandoMySQL.Transaction = transaccion;
                comandoMySQL.CommandText = procedimientoAlmacenado.CommandText;
                comandoMySQL.Parameters.AddRange(parametros.ToArray());
                comandoMySQL.CommandType = CommandType.StoredProcedure;
                var resultado = comandoMySQL.ExecuteReader();
                return resultado;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }

        public DataTable RunCommandDataTable(string comando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable listaTabla = new DataTable();
            connectionOpen();
            adaptador.SelectCommand = new MySqlCommand(comando, connection);
            adaptador.SelectCommand.CommandType = CommandType.Text;
            adaptador.Fill(listaTabla);
            adaptador.Dispose();
            connectionClose();
            return listaTabla;
        }

        public DataTable RunCommandDataTableWithParameter(List<MySqlParameter> parametros, string comando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable listaTabla = new DataTable();
            connectionOpen();
            adaptador.SelectCommand = new MySqlCommand(comando, connection);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            foreach (MySqlParameter Parametro in parametros)
            {
                adaptador.SelectCommand.Parameters.Add(Parametro);
            }
            adaptador.Fill(listaTabla);
            adaptador.Dispose();
            connectionClose();
            return listaTabla;
        }
    }
}
