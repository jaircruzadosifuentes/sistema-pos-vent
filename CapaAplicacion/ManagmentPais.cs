using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentPais
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly PaisDaoMysql paisDaoMysql;
        public ManagmentPais()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.paisDaoMysql = new PaisDaoMysql(gestorDaoMysql);
        }

        public List<Pais> GetPaises()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Pais> list = paisDaoMysql.GetPaises();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
