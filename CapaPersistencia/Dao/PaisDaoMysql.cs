using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class PaisDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public PaisDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public List<Pais> GetPaises()
        {
            MySqlCommand command = new MySqlCommand("stp_getValueComboBoxPais");
            List<Pais> list = new List<Pais>();
            Pais pais;
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
            };
            try
            {
                MySqlDataReader result = gestorDaoMysql.runCommandoProcedureSpParamater(command, parameters);
                while (result.Read())
                {
                    pais = new Pais()
                    {
                        PaisId = Convert.ToInt32(result["paisId"]),
                        Name = result["name"].ToString(),
                        State = Convert.ToInt32(result["state"])
                    };
                    list.Add(pais);
                }
                result.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
