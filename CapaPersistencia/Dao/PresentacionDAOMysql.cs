using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class PresentacionDAOMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public PresentacionDAOMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public bool DALInsertaPresentacion(UMedida uMedida)
        {
            MySqlCommand command = new MySqlCommand("stp_insert_presentacion");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmNombre", uMedida.Name);
                command.Parameters.AddWithValue("prmAbreviatura", uMedida.Abreviatura);
                command.Parameters.AddWithValue("prmEstado", uMedida.State);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALActualizaPresentacion(UMedida uMedida)
        {
            MySqlCommand command = new MySqlCommand("stp_update_presentacion");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmPresentacionId", uMedida.PresentationId);
                command.Parameters.AddWithValue("prmNombre", uMedida.Name);
                command.Parameters.AddWithValue("prmAbreviatura", uMedida.Abreviatura);
                command.Parameters.AddWithValue("prmEstado", uMedida.State);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALAnularPresentacion(int presentacionId)
        {
            MySqlCommand comando = new MySqlCommand("stp_putAnularPresentacion");
            try
            {
                comando = gestorDaoMysql.getCommandProcedure(comando);
                comando.Parameters.AddWithValue("prmPresentacionId", presentacionId);
                int i = comando.ExecuteNonQuery();
                return i > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllPresentacionesEnDataTable()
        {
            string comando = "stp_getAllPresentacionesEnDataTavle";
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTable(comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DALPresentacionesAnuladas()
        {
            string comando = "stp_getAllPresentacionesAnuladas";
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTable(comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DALGetAllPresentacionPorNombre(string nombre)
        {
            string comando = "stp_getAllPresentacionesPorNombre";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmNombre", nombre)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parameters, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
