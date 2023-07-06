using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentCategoria
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly CategoryDaoMysql categoryDAOMysql;
        public ManagmentCategoria()
        {
            gestorDaoMysql = new GestorDaoMysql();
            categoryDAOMysql = new CategoryDaoMysql(gestorDaoMysql);
        }
        public List<Category> ServiceGetCategoriasParaVenta()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Category> listCategories = categoryDAOMysql.DALGetCategoriasParaVenta();
                gestorDaoMysql.connectionClose();
                return listCategories;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceCategoriasInactivos()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = categoryDAOMysql.DALCategoriasInactivos();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllCategoriasEnDataTable()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = categoryDAOMysql.GetAllCategoriasEnDataTable();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetCategoriaPorNombre(string nombre)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = categoryDAOMysql.DALGetCategoriaPorNombre(nombre);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ServiceAnularCategoria(int categoriaId)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool anula = categoryDAOMysql.DALAnularCategoria(categoriaId);
                if (anula)
                {
                    gestorDaoMysql.finishTransaction();
                }
                else
                {
                    gestorDaoMysql.cancelTransaction();
                }
                return anula;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALInsertaCategoria(Category category, string tipoTransaccion)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool inserta = categoryDAOMysql.DALInsertaCategoria(category, tipoTransaccion);
                if(inserta)
                {
                    gestorDaoMysql.finishTransaction();
                }
                else
                {
                    gestorDaoMysql.cancelTransaction();
                }
                return inserta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALActualizaCategoria(Category category, string tipoTransaccion)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool inserta = categoryDAOMysql.DALActualizaCategoria(category, tipoTransaccion);
                if(inserta)
                {
                    gestorDaoMysql.finishTransaction();
                }
                else
                {
                    gestorDaoMysql.cancelTransaction();
                }
                return inserta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
