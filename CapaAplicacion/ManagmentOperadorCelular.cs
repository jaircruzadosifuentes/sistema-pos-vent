using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentOperadorCelular
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly TipoOperadorDaoMysql tipoOperadorDaoMysql;
        public ManagmentOperadorCelular()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.tipoOperadorDaoMysql = new TipoOperadorDaoMysql(gestorDaoMysql);
        }
        public List<TipoOperador> GetAllTipoOperadorCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<TipoOperador> list = tipoOperadorDaoMysql.GetAllTipoOperador();
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
