using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class CajaDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public CajaDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }

        public List<Caja> DALGetCajaPorSedeIdEnCombo(int sedeId)
        {
            List<Caja> listCaja = new List<Caja>();
            Caja caja;
            string consultaSQL;
            consultaSQL = "SELECT mc.caja_id AS cajaId, mc.name ";
            consultaSQL += "FROM mnt_sede s ";
            consultaSQL += "INNER JOIN system_caja_sede scc ON s.sede_id = scc.sede_id ";
            consultaSQL += "INNER JOIN mnt_caja mc ON mc.caja_id = scc.caja_id ";
            consultaSQL += "WHERE s.sede_id = '" + sedeId + "' AND mc.state = 1; ";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    caja = GetParametrosCajaPorSede(resultadoMysql);
                    listCaja.Add(caja);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listCaja;
        }

        public Caja GetParametrosCajaPorSede(MySqlDataReader resultadoMysql)
        {
            Caja caja = new Caja();
            caja.CajaId = Convert.ToInt32(resultadoMysql["cajaId"]);
            caja.Name = resultadoMysql["name"].ToString();
            return caja;
        }

        public List<Sede> DALGetSedesParaCombo()
        {
            List<Sede> sedes = new List<Sede>();
            Sede sede;
            string consultaSQL;
            consultaSQL = "SELECT s.sede_id AS sedeId, s.name ";
            consultaSQL += "FROM mnt_sede s ";
            consultaSQL += "WHERE s.state = 1; ";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    sede = GetParametrosSede(resultadoMysql);
                    sedes.Add(sede);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return sedes;
        }

        public Sede GetParametrosSede(MySqlDataReader resultadoMysql)
        {
            Sede sede = new Sede();
            sede.SedeId = Convert.ToInt32(resultadoMysql["sedeId"]);
            sede.Name = resultadoMysql["name"].ToString();
            return sede;
        }

        public List<Caja> DALGetCajaEnCombo()
        {
            List<Caja> listCaja = new List<Caja>();
            Caja caja;
            string consultaSQL;
            consultaSQL = "SELECT caja_id AS cajaId, UPPER(name) AS name ";
            consultaSQL += "FROM mnt_caja ";
            consultaSQL += "WHERE state = 1";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    caja = GetParamsCajaForCombo(resultadoMysql);
                    listCaja.Add(caja);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listCaja;
        }

        public Caja GetParamsCajaForCombo(MySqlDataReader resultadoMysql)
        {
            Caja caja = new Caja();
            caja.CajaId = Convert.ToInt32(resultadoMysql["cajaId"]);
            caja.Name = resultadoMysql["name"].ToString();
            return caja;
        }
        public bool GetStateOpenCaja(string gsUserName)
        {
            bool state = false;
            string consultaSQL;
            consultaSQL = " SELECT oc.cerrado " + "\r\n";
            consultaSQL += " FROM ope_caja oc " + "\r\n";
            consultaSQL += " WHERE DATE(oc.open_caja_date) = DATE(NOW()) AND oc.cUsuario = " + "'" + gsUserName + "'";

            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                if (resultadoMysql.Read())
                {
                    state = !Convert.ToBoolean(resultadoMysql["cerrado"]);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return state;
        }
        public bool DALVerificaCajaCerrada(string gsUserName, int cajaId)
        {
            bool state = false;
            string consultaSQL;
            consultaSQL = " SELECT cerrado " + "\r\n";
            consultaSQL += " FROM ope_caja oc " + "\r\n";
            consultaSQL += " WHERE DATE(oc.open_caja_date) = DATE(NOW()) AND oc.cUsuario = " + "'" + gsUserName + "' AND oc.caja_id = '" + cajaId + "'";

            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                if (resultadoMysql.Read())
                {
                    state = Convert.ToBoolean(resultadoMysql["cerrado"]);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return state;
        }
        public DataTable DALGetMontoParaCajaChica(string codigoUsuario, int cajaId, int sedeId)
        {
            string comando = "stp_getMontosParaCierreCajaChica";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("codigoUsuario", codigoUsuario),
                new MySqlParameter("nCajaId", cajaId),
                new MySqlParameter("nSedeId", sedeId),
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
        public DataTable DALGetCajaAperturadaPorFecha(DateTime dateTime)
        {
            string comando = "stp_getAllCajasAperturadasPorFecha";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmFecha", dateTime),
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
        public DataTable DALGetCajaAperturadaPorCodigo(string userCode)
        {
            string comando = "stp_getAllCajasAperturadasPorCodUsuario";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
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
        public DataTable DALVerificaCajasAsignadasASede(int sedeId, int cajaId)
        {
            string comando = "stp_verificaCajasAsignadasASede";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prm_sede_id", sedeId),
                new MySqlParameter("prm_caja_id", cajaId),
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
        public DataTable DALGetOperationForCode(string userCode)
        {
            string comando = "stp_getAllOperationsForCode";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("code_operation", userCode),
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
        public DataTable DALGetCajaPorNombre(string nombre)
        {
            string comando = "stp_getCajaPorNombre";
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
        public DataTable DALGetCajasAperturadasConMonto()
        {
            string comando = "stp_getAllCajasAperturadas";
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
        public DataTable DALGetAllCajas()
        {
            string comando = "stp_getAllCajas";
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

        public bool DALInsertCaja(Caja caja, string type_transaction)
        {
            MySqlCommand command = new MySqlCommand("stp_insert_update_caja");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmNameCajaId", caja.CajaId);
                command.Parameters.AddWithValue("prmNameCaja", caja.Name);
                command.Parameters.AddWithValue("prmTypeTransaction", type_transaction);
                command.Parameters.AddWithValue("prmEstado", caja.State);

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
    }
}
