using CapaPersistencia.Mysql;
using System;
using CapaPersistencia.Interfaces;
using CapaEntidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace CapaPersistencia.Dao
{
    public class UserDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public UserDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }

        public User AccessToTheSystem(string userName, string password)
        {
            MySqlCommand command = new MySqlCommand("sp_AccessThoTheSystem");
            User user = null;
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmUser", userName),
                new MySqlParameter("prmPassword", password)
            };
            try
            {
                MySqlDataReader result = gestorDaoMysql.runCommandoProcedureSpParamater(command, parameters);
                if(result.Read())
                {
                    Rol rol = new Rol()
                    {
                        RolId = Convert.ToInt32(result["rol_id"]),
                        Name = result["name_rol"].ToString()
                    };
                    Arquetipo arquetipo = new Arquetipo()
                    {
                        ArquetipoId = Convert.ToInt32(result["arquetipo_id"]),
                        Name = result["name_arquetipo"].ToString(),
                        Abbreviation = result["abbreviation"].ToString()
                    };
                    Sede sede = new Sede()
                    {
                        SedeId = Convert.ToInt32(result["sedeId"]),
                        Name = result["sede"].ToString()
                    };
                    Caja caja = new Caja()
                    {
                        CajaId = Convert.ToInt32(result["cajaId"]),
                        Name = result["caja"].ToString()
                    };
                    user = new User()
                    {
                        UserId = Convert.ToInt32(result["user_id"]),
                        State = Convert.ToBoolean(result["state"]),
                        UserName = result["user_name"].ToString(),
                        Password = result["password"].ToString(),
                        Names = result["names"].ToString(),
                        LastPatern = result["last_patern"].ToString(),
                        LastMother = result["last_mother"].ToString(),
                    };
                    user.Rol = rol;
                    user.Arquetipo = arquetipo;
                    user.Sede = sede;
                    user.Caja = caja;
                }
                result.Close();
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetEmpleadosPorApellidos(string apellidos)
        {
            string comando = "stp_getEmpleadoPorApellidos";
            List <MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmApellidos", apellidos)
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
        public DataTable DALValidarSiEsAdmiYRecuperaClave(string codigoUsuario)
        {
            string comando = "stpValidarSiEsAdministradorYRecuperaClave";
            List <MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prm_user_name", codigoUsuario)
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
        public DataTable DALGetUsuarioPorCodigo(string codigoUsuario)
        {
            string comando = "stp_getUsuarioPorCodigo";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmCodUsuario", codigoUsuario)
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
        public DataTable GetEmpleadosPorNombres(string nombres)
        {
            string comando = "stp_getEmpleadoPorNombres";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmNombres", nombres)
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
        public DataTable GetEmpleadosPorCargo(string cargo)
        {
            string comando = "stp_getEmpleadoPorCargo";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmCargo", cargo)
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
        public DataTable GetEmpleadosPorCodigo(string codigoEmpleado)
        {
            string comando = "stp_getEmpleadoPorCodigo";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmCodigo", codigoEmpleado)
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
        public DataTable GetAllUser()
        {
            string comando = "stp_getAllUser";
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
        public DataTable DALGetClientes()
        {
            string comando = "stp_getAllClientes";
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
        public DataTable GetAllUsersBanned()
        {
            string comando = "stp_getAllUserBanned";
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
        public DataTable GetCellphoneNumber(int userId)
        {
            string comando = "stp_getCellphoneNumbers";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("user_id", userId)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALInsertaUsuario(User user, string tipo)
        {
            MySqlCommand command = new MySqlCommand("stp_insert_update_usuario");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmPersonaId", user.UserId);
                command.Parameters.AddWithValue("prmNames", user.Names);
                command.Parameters.AddWithValue("prmLastPatern", user.LastPatern);
                command.Parameters.AddWithValue("prmLastMother", user.LastMother);
                command.Parameters.AddWithValue("prmDireccion", user.Direction);
                command.Parameters.AddWithValue("prmPaisId", user.Pais.PaisId);
                command.Parameters.AddWithValue("prmTipoDocId", user.TipoDocumentoId);
                command.Parameters.AddWithValue("prmNumeroDoc", user.NumeroDoc);
                command.Parameters.AddWithValue("prmCelular", user.Cellphone);
                command.Parameters.AddWithValue("prmTieneCorreoBit", user.TieneCorreoBit);
                command.Parameters.AddWithValue("prmCorreoElectronico", user.EmailAddress);
                command.Parameters.AddWithValue("prmPassword", user.Password);
                command.Parameters.AddWithValue("prmCargoId", user.Rol.RolId);
                command.Parameters.AddWithValue("prmSexo", user.Sexo);
                command.Parameters.AddWithValue("prmTipo", tipo);
                command.Parameters.AddWithValue("prmCajaId", user.Caja.CajaId);
                command.Parameters.AddWithValue("prmSedeId", user.Sede.SedeId);
                command.Parameters.AddWithValue("prmHorarioId", user.Horario.HorarioId);
                 
                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByCodUser(string codUser)
        {
            string comando = "stp_getByCodUser";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("codUser", codUser)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALDarDeBajaTrabajador(int trabajadorId)
        {
            MySqlCommand comando = new MySqlCommand("stp_DarDeBajaTrabajadores");
            try
            {
                comando = gestorDaoMysql.getCommandProcedure(comando);
                comando.Parameters.AddWithValue("prmTrabajadorId", trabajadorId);
                int i = comando.ExecuteNonQuery();
                return i > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
