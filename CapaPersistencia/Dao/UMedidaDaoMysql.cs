using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class UMedidaDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public UMedidaDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public List<UMedida> GetAllPresentationForCombo()
        {
            List<UMedida> listUMedidas = new List<UMedida>();
            UMedida uMedida;
            string consultaSQL;
            consultaSQL = "SELECT presentation_id AS presentationId, UPPER(name) AS name, state ";
            consultaSQL += "FROM mnt_presentation WHERE state = 1";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    uMedida = GetParamsPresentationForCombo(resultadoMysql);
                    listUMedidas.Add(uMedida);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listUMedidas;
        }

        public UMedida GetParamsPresentationForCombo(MySqlDataReader resultadoMysql)
        {
            UMedida uMedida = new UMedida();
            uMedida.PresentationId = Convert.ToInt32(resultadoMysql["presentationId"]);
            uMedida.Name = resultadoMysql["name"].ToString();
            uMedida.State = Convert.ToInt32(resultadoMysql["state"]);
            return uMedida;
        }
    }
}
