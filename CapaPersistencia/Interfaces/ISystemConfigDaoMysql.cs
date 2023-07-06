using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using MySql.Data.MySqlClient;

namespace CapaPersistencia.Interfaces
{
    public interface ISystemConfigDaoMysql
    {
        List<SystemConfig> GetAllSystemConfig();
        SystemConfig GetParamsSystemConfig(MySqlDataReader resultadoMysql);
    }
}
