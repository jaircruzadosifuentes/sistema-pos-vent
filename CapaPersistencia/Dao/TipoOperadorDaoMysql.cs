using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class TipoOperadorDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public TipoOperadorDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public List<TipoOperador> GetAllTipoOperador()
        {
            List<TipoOperador> list = new List<TipoOperador>();
            TipoOperador tipoOperador;
            string consultaSQL;
            consultaSQL = "SELECT operador_id AS operadorId, UPPER(name) AS name, state ";
            consultaSQL += "FROM mnt_tipo_operador";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    tipoOperador = GetParamsTipoOperadorForCombo(resultadoMysql);
                    list.Add(tipoOperador);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return list;
        }

        public TipoOperador GetParamsTipoOperadorForCombo(MySqlDataReader resultadoMysql)
        {
            TipoOperador tipoOperador = new TipoOperador();
            tipoOperador.OperadorId = Convert.ToInt32(resultadoMysql["operadorId"]);
            tipoOperador.Name = resultadoMysql["name"].ToString();
            tipoOperador.State = Convert.ToInt32(resultadoMysql["state"]);
            return tipoOperador;
        }
    }
}
