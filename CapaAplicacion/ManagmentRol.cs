using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentRol
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly RolDaoMysql rolDaoMysql;
        public ManagmentRol()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.rolDaoMysql = new RolDaoMysql(gestorDaoMysql);
        }
        public List<Rol> getAllRol()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Rol> list = rolDaoMysql.GetAllRol();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
