using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;

namespace CapaPersistencia.Dao
{
    public class ProductDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public ProductDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }

        public DataTable DALGetProductoPorCodigoBarrasConsulta(string codigoBarras)
        {
            string comando = "stp_getByCodigoBarrasProductos";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmCodigoBarras", codigoBarras)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByNameProduct(string name)
        {
            string comando = "stp_getByNameProduct";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmName", name)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByCategoryProduct(string category)
        {
            string comando = "stp_getByCategoryProduct";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmCategory", category)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByUMedidaProduct(string uMedida)
        {
            string comando = "stp_getByUMedidaProduct";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmUMedida", uMedida)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByCodBarrasProduct(string uMedida)
        {
            string comando = "stp_getByCodBarrasProduct";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmCodBarras", uMedida)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DALGetProductoPorNombre(string nombre)
        {
            string comando = "stp_getProductByNombre";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmNombreDes", nombre)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DALGetProductosPorIdCategoria(int categoriaId)
        {
            string comando = "stp_getProductosPorIdCategoria";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmIdCategoria", categoriaId)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable DALValidaDatosInventario(int tipo, string filtro)
        {
            string comando = "stp_validaDatos_inventario";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmTipoFiltro", tipo),
                new MySqlParameter("prmFiltro", filtro)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                return adaptador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DALRecuperaIdPorCodigo(int tipo, string filtro)
        {
            string comando = "stpRecuperarIdPorCodigo";
            int id = 0;
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmTipoFiltro", tipo),
                new MySqlParameter("prmFiltro", filtro)
            };
            try
            {
                DataTable adaptador = gestorDaoMysql.RunCommandDataTableWithParameter(parametros, comando);
                if(adaptador.Rows.Count > 0)
                {
                    id = Convert.ToInt32(adaptador.Rows[0]["ID"]);
                }
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllProducts()
        {
            string comando = "stp_getAllProducts";
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
        public DataTable DALGetAllKardex()
        {
            string comando = "stp_getAllKardex";
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
        public DataTable GetAllProductsBanned()
        {
            string comando = "stp_getAllProductsBanned";
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
        public bool InsertProduct(Product product)
        {
            MySqlCommand command = new MySqlCommand("stp_insertProduct");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmName", product.Name);
                command.Parameters.AddWithValue("prmBarCode", product.BarCode);
                command.Parameters.AddWithValue("prmStock", product.Stock);
                command.Parameters.AddWithValue("prmStockAlmacen", product.StockAlmacen);
                command.Parameters.AddWithValue("prmPrice", product.Price);
                command.Parameters.AddWithValue("prmCostPrice", product.CostPrice);
                command.Parameters.AddWithValue("prmDueDate", product.DueDate);
                command.Parameters.AddWithValue("prmUtility", product.Utility);
                command.Parameters.AddWithValue("prmCategoryId", product.Category.CategoryId);
                command.Parameters.AddWithValue("prmUmedidaId", product.UMedida.PresentationId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALMoverStockAlmacenAVenta(int productoId, decimal cantidadAlmacen, decimal cantidadVenta)
        {
            MySqlCommand command = new MySqlCommand("stp_moverStockAlmacenAVenta");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmProductoID", productoId);
                command.Parameters.AddWithValue("prmCantidadAlmacen", cantidadAlmacen);
                command.Parameters.AddWithValue("prmCantidadVenta", cantidadVenta);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateProduct(Product product)
        {
            MySqlCommand command = new MySqlCommand("stp_updateProduct");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmProductId", product.ProductId);
                command.Parameters.AddWithValue("prmName", product.Name);
                command.Parameters.AddWithValue("prmBarCode", product.BarCode);
                command.Parameters.AddWithValue("prmStock", product.Stock);
                command.Parameters.AddWithValue("prmStockAlmacen", product.StockAlmacen);
                command.Parameters.AddWithValue("prmPrice", product.Price);
                command.Parameters.AddWithValue("prmCostPrice", product.CostPrice);
                command.Parameters.AddWithValue("prmDueDate", product.DueDate);
                command.Parameters.AddWithValue("prmUtility", product.Utility);
                command.Parameters.AddWithValue("prmCategoryId", product.Category.CategoryId);
                command.Parameters.AddWithValue("prmUmedidaId", product.UMedida.PresentationId);
                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool BannedProduct(int ProductId, string bannedDate)
        {
            MySqlCommand comando = new MySqlCommand("stp_bannedProduct");
            try
            {
                comando = gestorDaoMysql.getCommandProcedure(comando);
                comando.Parameters.AddWithValue("prmProductId", ProductId);
                comando.Parameters.AddWithValue("prmBannedDate", bannedDate);
                int i = comando.ExecuteNonQuery();
                return i > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public bool DALActivarProductos(int ProductId)
        {
            MySqlCommand comando = new MySqlCommand("stp_activarProductos");
            try
            {
                comando = gestorDaoMysql.getCommandProcedure(comando);
                comando.Parameters.AddWithValue("productoId", ProductId);
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
