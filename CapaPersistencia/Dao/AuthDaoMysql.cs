using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class AuthDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public AuthDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public bool PermisoEspecial(string userName, string code)
        {
            bool permiso = false;
            string consultaSQL;
            consultaSQL = " SELECT COUNT(1) AS Contador ";
            consultaSQL += " FROM auth_special_permission ";
            consultaSQL += " WHERE user_name = " + "'" + userName + "'" + " AND code = " + "'" + code + "'" + " OR (SELECT is_admi FROM mnt_user WHERE is_admi = 1 AND g_user_name = " + "'" + userName + "'" + ") = 1";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                if (resultadoMysql.Read())
                {
                    int contador = 0;
                    contador = Convert.ToInt32(resultadoMysql["contador"]);
                    permiso = contador == 1 || contador == 3;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return permiso;
        }

        public bool DALInsertPermisoOperacion(string codeOperation, string userName)
        {
            MySqlCommand command = new MySqlCommand("stp_insert_permiso");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmCodeOperation", codeOperation);
                command.Parameters.AddWithValue("prmUserName", userName);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALQuitarPermisos(string codeOperation, string userName)
        {
            MySqlCommand command = new MySqlCommand("stp_quitarPermisos");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmCodigo", codeOperation);
                command.Parameters.AddWithValue("prmCodigoUsuario", userName);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DALVerificaOperacionesExistentes(string codeOperation, string userCode)
        {
            string comando = "stp_verificaPermisoExistente";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmCodeOperation", codeOperation),
                new MySqlParameter("prmUserCode", userCode),
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parameters, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
