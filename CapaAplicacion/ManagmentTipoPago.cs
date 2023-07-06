using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentTipoPago
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly TipoPagoDaoMysql tipoPagoDaoMysql;
        public ManagmentTipoPago()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            tipoPagoDaoMysql = new TipoPagoDaoMysql(gestorDaoMysql);
        }
        public List<TipoPago> ServiceGetTipoPagoEnCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<TipoPago> tipoPagos = tipoPagoDaoMysql.DALGetTipoPagoEnCombo();
                gestorDaoMysql.connectionClose();
                return tipoPagos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
