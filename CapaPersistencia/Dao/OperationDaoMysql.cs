using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaPersistencia.Dao
{
    public class OperationDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public OperationDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public DataTable DALGetAllOperationsForPermiss(string userCode)
        {
            string comando = "stp_getAllOperationsForPermiss";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmUserName", userCode)
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
        public DataTable DALGetAllOperationsForCode(string codeOperation)
        {
            string comando = "stp_getAllOperationsForCode";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("code_operation", codeOperation)
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
        public DataTable DALGetOperationForCodUser(string codeUsuario)
        {
            string comando = "stp_getAllOperationsForCodUsuario";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmCodigoUsuario", codeUsuario)
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
        public string StoreProcedureForType(int type)
        {
            string storeProcedure = "";
            switch (type)
            {
                case 1:
                    storeProcedure = "stp_getAllOperations";
                    break;
                case 2:
                    storeProcedure = "stp_getAllOperationsTreeView";
                    break;
                case 3:
                    storeProcedure = "stpGetAllOperationsForTreeViewPermiss";
                    break;
                default:
                    break;
            }
            return storeProcedure;
        }
        public List<Operation> ListOperations(string userName, int tipoTreeView)
        {
            string storeProcedure = StoreProcedureForType(tipoTreeView);

            MySqlCommand command = new MySqlCommand(storeProcedure);
            List<Operation> listOperations = new List<Operation>();
            Operation operation;
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmUserName", userName)
            };
            try
            {
                MySqlDataReader result = gestorDaoMysql.runCommandoProcedureSpParamater(command, parameters);
                while(result.Read())
                {
                    operation = new Operation()
                    {
                        OperationId = Convert.ToInt32(result["operation_id"]),
                        IdentificationCode = result["identification_code"].ToString(),
                        Description = result["description"].ToString(),
                        Level = Convert.ToInt32(result["level"]),
                        Raiz = result["raiz"].ToString(),
                        LastFechaModification = result["last_fecha_modification"].ToString(),
                        State = Convert.ToInt32(result["state"])
                    };
                    listOperations.Add(operation);
                }
                result.Close();
                return listOperations;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
