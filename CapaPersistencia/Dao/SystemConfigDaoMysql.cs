using System;
using System.Collections.Generic;
using System.Text;
using CapaPersistencia.Mysql;
using CapaPersistencia.Interfaces;
using CapaEntidades;
using MySql.Data.MySqlClient;

namespace CapaPersistencia.Dao
{
    public class SystemConfigDaoMysql: ISystemConfigDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public SystemConfigDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        
        public List<SystemConfig> GetAllSystemConfig()
        {
            List<SystemConfig> listOfConfigs = new List<SystemConfig>();
            SystemConfig systemConfig;
            string consultaSQL;
            consultaSQL = "SELECT config_id, name, value ";
            consultaSQL += "FROM system_config";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    systemConfig = GetParamsSystemConfig(resultadoMysql);
                    listOfConfigs.Add(systemConfig);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listOfConfigs;
        }

        public SystemConfig GetParamsSystemConfig(MySqlDataReader resultadoMysql)
        {
            SystemConfig systemConfig = new SystemConfig();
            systemConfig.ConfigId = Convert.ToInt32(resultadoMysql["config_id"]);
            systemConfig.Name = resultadoMysql["name"].ToString();
            systemConfig.Value = resultadoMysql["value"].ToString();
            return systemConfig;
        }

        public bool DALSettingUpdate(Configuraciones configuraciones)
        {
            MySqlCommand command = new MySqlCommand("stp_setting_update");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmTitle", configuraciones.Titulo);
                command.Parameters.AddWithValue("prmValor", configuraciones.Valor);

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
