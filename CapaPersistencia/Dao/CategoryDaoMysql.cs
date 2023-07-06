using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class CategoryDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public CategoryDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }

        public List<Category> DALGetCategoriasParaVenta()
        {
            List<Category> listCategories = new List<Category>();
            Category category;
            string consultaSQL;
            consultaSQL = "SELECT category_id AS categoryId, UPPER(name) AS name, state, mostrarEnVenta ";
            consultaSQL += "FROM mnt_category ";
            consultaSQL += "WHERE state = 1";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    category = GetParamsCategoriaParaVenta(resultadoMysql);
                    listCategories.Add(category);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listCategories;
        }

        public Category GetParamsCategoriaParaVenta(MySqlDataReader resultadoMysql)
        {
            Category category = new Category();
            category.CategoryId = Convert.ToInt32(resultadoMysql["categoryId"]);
            category.Name = resultadoMysql["name"].ToString();
            category.State = Convert.ToInt32(resultadoMysql["state"]);
            category.MostrarEnVenta = Convert.ToInt32(resultadoMysql["mostrarEnVenta"]);
            return category;
        }

        public DataTable DALCategoriasInactivos()
        {
            string comando = "stp_getAllCategoriasInactivos";
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
        public DataTable GetAllCategoriasEnDataTable()
        {
            string comando = "stp_getAllCategoriasEnDataTable";
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
        public DataTable DALGetCategoriaPorNombre(string nombre)
        {
            string comando = "stp_getCategoriaPorNombre";
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
        public List<Category> GetAllCategoryForCombo()
        {
            List<Category> listCategories = new List<Category>();
            Category category;
            string consultaSQL;
            consultaSQL = "SELECT category_id AS categoryId, UPPER(name) AS name, state ";
            consultaSQL += "FROM mnt_category ";
            consultaSQL += "WHERE state = 1";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    category = GetParamsCategoryForCombo(resultadoMysql);
                    listCategories.Add(category);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listCategories;
        }

        public Category GetParamsCategoryForCombo(MySqlDataReader resultadoMysql)
        {
            Category category = new Category();
            category.CategoryId = Convert.ToInt32(resultadoMysql["categoryId"]);
            category.Name = resultadoMysql["name"].ToString();
            category.State = Convert.ToInt32(resultadoMysql["state"]);
            return category;
        }
        public bool DALInsertaCategoria(Category category, string tipoTransaccion)
        {
            MySqlCommand command = new MySqlCommand("stp_insert_categoria");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmNombre", category.Name);
                command.Parameters.AddWithValue("prmTipoTransaccion", tipoTransaccion);
                command.Parameters.AddWithValue("prmEstado", category.State);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALActualizaCategoria(Category category, string tipoTransaccion)
        {
            MySqlCommand command = new MySqlCommand("stp_update_categoria");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmCategoriaId", category.CategoryId);
                command.Parameters.AddWithValue("prmNombre", category.Name);
                command.Parameters.AddWithValue("prmTipoTransaccion", tipoTransaccion);
                command.Parameters.AddWithValue("prmEstado", category.State);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALAnularCategoria(int categoriaId)
        {
            MySqlCommand comando = new MySqlCommand("stp_putAnularCategoria");
            try
            {
                comando = gestorDaoMysql.getCommandProcedure(comando);
                comando.Parameters.AddWithValue("prmCategoriaId", categoriaId);
                int i = comando.ExecuteNonQuery();
                return i > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
