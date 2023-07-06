using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class RolDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public RolDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public List<Rol> GetAllRol()
        {
            List<Rol> list = new List<Rol>();
            Rol rol;
            string consultaSQL;
            consultaSQL = "SELECT rol_id AS rolId, name ";
            consultaSQL += "FROM mnt_rol";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    rol = GetParamsRol(resultadoMysql);
                    list.Add(rol);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return list;
        }

        public Rol GetParamsRol(MySqlDataReader resultadoMysql)
        {
            Rol rol = new Rol();
            rol.RolId = Convert.ToInt32(resultadoMysql["rolId"]);
            rol.Name = resultadoMysql["name"].ToString();
            return rol;
        }
    }
}
