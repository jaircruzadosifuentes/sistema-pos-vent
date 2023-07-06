using System;
using System.Collections.Generic;
using System.Text;
using CapaPersistencia;
using CapaPersistencia.Mysql;
using CapaPersistencia.Dao;
using CapaEntidades;
using System.Data;

namespace CapaAplicacion
{
    public class ManagmentProducts
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly ProductDaoMysql productDaoMysql;
        private readonly CategoryDaoMysql categoryDaoMysql;
        private readonly UMedidaDaoMysql uMedidaDaoMysql;
        public ManagmentProducts()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.productDaoMysql = new ProductDaoMysql(gestorDaoMysql);
            this.categoryDaoMysql = new CategoryDaoMysql(gestorDaoMysql);
            this.uMedidaDaoMysql = new UMedidaDaoMysql(gestorDaoMysql);
        }

        public DataTable GetAllProducts()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProducts = productDaoMysql.GetAllProducts();
                gestorDaoMysql.connectionClose();
                return listProducts;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetAllProductsBanned()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProducts = productDaoMysql.GetAllProductsBanned();
                gestorDaoMysql.connectionClose();
                return listProducts;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetByNameProduct(string name)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductByName = productDaoMysql.GetByNameProduct(name);
                gestorDaoMysql.connectionClose();
                return listProductByName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceValidaDatosInventario(int tipo, string filtro)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductByName = productDaoMysql.DALValidaDatosInventario(tipo, filtro);
                gestorDaoMysql.connectionClose();
                return listProductByName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public int ServiceRecuperaIdPorCodigo(int tipo, string filtro)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                int listProductByName = productDaoMysql.DALRecuperaIdPorCodigo(tipo, filtro);
                gestorDaoMysql.connectionClose();
                return listProductByName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetProductoPorCodigoBarrasConsulta(string codigoBarras)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductByName = productDaoMysql.DALGetProductoPorCodigoBarrasConsulta(codigoBarras);
                gestorDaoMysql.connectionClose();
                return listProductByName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByCategoryProduct(string category)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductByCategory = productDaoMysql.GetByCategoryProduct(category);
                gestorDaoMysql.connectionClose();
                return listProductByCategory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByUMedidaProduct(string uMedida)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductByUMedida = productDaoMysql.GetByUMedidaProduct(uMedida);
                gestorDaoMysql.connectionClose();
                return listProductByUMedida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetByCodBarrasProduct(string codBarras)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductCodBarras = productDaoMysql.GetByCodBarrasProduct(codBarras);
                gestorDaoMysql.connectionClose();
                return listProductCodBarras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        public DataTable ServiceGetProductoPorNombre(string nombre)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductCodBarras = productDaoMysql.DALGetProductoPorNombre(nombre);
                gestorDaoMysql.connectionClose();
                return listProductCodBarras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetProductosPorIdCategoria(int categoriaId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductCodBarras = productDaoMysql.DALGetProductosPorIdCategoria(categoriaId);
                gestorDaoMysql.connectionClose();
                return listProductCodBarras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetAllKardex()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable listProductCodBarras = productDaoMysql.DALGetAllKardex();
                gestorDaoMysql.connectionClose();
                return listProductCodBarras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Category> GetAllCategoryForCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Category> listCategories = categoryDaoMysql.GetAllCategoryForCombo();
                gestorDaoMysql.connectionClose();
                return listCategories;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<UMedida> GetAllUMedidaForCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<UMedida> listUMedidas = uMedidaDaoMysql.GetAllPresentationForCombo();
                gestorDaoMysql.connectionClose();
                return listUMedidas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool InsertaProduct(Product product)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool productInsert = productDaoMysql.InsertProduct(product);
                if (productInsert)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return productInsert;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ServiceMoverStockAlmacenAVenta(int productoId, decimal cantidadAlmacen, decimal cantidadVenta)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool productInsert = productDaoMysql.DALMoverStockAlmacenAVenta(productoId, cantidadAlmacen, cantidadVenta);
                if (productInsert)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return productInsert;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateProduct(Product product)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool productUpdate = productDaoMysql.UpdateProduct(product);
                if (productUpdate)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return productUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool BannedProduct(int ProductId, string bannedDate)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool banned = productDaoMysql.BannedProduct(ProductId, bannedDate);
                if (banned)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return banned;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ServiceActivarProductos(int productoId)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool banned = productDaoMysql.DALActivarProductos(productoId);
                if (banned)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return banned;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
