using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class SedeDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public SedeDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public DataTable DALGetAllSedes()
        {
            string comando = "stp_getAllSedes";
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTable(comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DALGetSedePorNombre(string nombre)
        {
            string comando = "stp_getAllSedePorNombre";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmNombre", nombre),
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
        public bool DALInsertSede(Sede sede, string type_transaction)
        {
            MySqlCommand command = new MySqlCommand("stp_insert_update_sede");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmSedeId", sede.SedeId);
                command.Parameters.AddWithValue("prmSedeDesc", sede.Name);
                command.Parameters.AddWithValue("prmDireccion", sede.Address);
                command.Parameters.AddWithValue("prmEstado", sede.State);
                command.Parameters.AddWithValue("prmTipo", type_transaction);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALDarDeBajaCaja(int cajaId)
        {
            MySqlCommand command = new MySqlCommand("stp_dar_baja_caja");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmCajaId", cajaId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Sede> DALGetSedeEnCombo()
        {
            List<Sede> listSede = new List<Sede>();
            Sede sede;
            string consultaSQL;
            consultaSQL = " SELECT s.sede_id AS sedeId, s.name ";
            consultaSQL += " FROM mnt_sede s ";
            consultaSQL += " WHERE s.state = 1 ";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    sede = GetParametrosSede(resultadoMysql);
                    listSede.Add(sede);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listSede;
        }

        public Sede GetParametrosSede(MySqlDataReader resultadoMysql)
        {
            Sede sede = new Sede();
            sede.SedeId = Convert.ToInt32(resultadoMysql["sedeId"]);
            sede.Name = resultadoMysql["name"].ToString();
            return sede;
        }

        public List<Operation> DALListCajasAsignadasASede()
        {
            MySqlCommand command = new MySqlCommand("stp_getAllCajasAsignadasASede");
            List <Operation> listOperations = new List<Operation>();
            Operation operation;
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
            };
            try
            {
                MySqlDataReader result = gestorDaoMysql.runCommandoProcedureSpParamater(command, parameters);
                while (result.Read())
                {
                    operation = new Operation()
                    {
                        OperationId = Convert.ToInt32(result["operation_id"]),
                        //IdentificationCode = result["identification_code"].ToString(),
                        Description = result["description"].ToString(),
                        Level = Convert.ToInt32(result["level"]),
                        Raiz = result["raiz"].ToString(),
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
