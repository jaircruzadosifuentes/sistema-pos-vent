using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class TipoPagoDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public TipoPagoDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public List<TipoPago> DALGetTipoPagoEnCombo()
        {
            List<TipoPago> listCaja = new List<TipoPago>();
            TipoPago tipoPago;
            string consultaSQL;
            consultaSQL = "SELECT tipoPagoId, nombre ";
            consultaSQL += "FROM mnt_tipo_pago ";
            consultaSQL += "WHERE estado = 1";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    tipoPago = GetParamsTipoPagoForCombo(resultadoMysql);
                    listCaja.Add(tipoPago);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listCaja;
        }

        public TipoPago GetParamsTipoPagoForCombo(MySqlDataReader resultadoMysql)
        {
            TipoPago tipoPago = new TipoPago
            {
                tipoPagoId = Convert.ToInt32(resultadoMysql["tipoPagoId"]),
                nombre = resultadoMysql["nombre"].ToString()
            };
            return tipoPago;
        }
    }
}
