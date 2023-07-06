using System;
using System.Collections.Generic;
using CapaAplicacion.Interfaces;
using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;

namespace CapaAplicacion
{
    public class ManagmentSystemConfig: IManagmentSystemConfig
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly SystemConfigDaoMysql systemConfigDaoMysql;
        public ManagmentSystemConfig()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.systemConfigDaoMysql = new SystemConfigDaoMysql(gestorDaoMysql);
        }

        public List<SystemConfig> GetAllSystemConfig()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<SystemConfig> listAllSystemConfig = systemConfigDaoMysql.GetAllSystemConfig();
                gestorDaoMysql.connectionClose();
                return listAllSystemConfig;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ServiceSettingUpdate(Configuraciones configuraciones)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool save = systemConfigDaoMysql.DALSettingUpdate(configuraciones);
                if(save)
                {
                    gestorDaoMysql.finishTransaction();
                }
                else
                {
                    gestorDaoMysql.cancelTransaction();
                }
                return save;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }
    }
}
