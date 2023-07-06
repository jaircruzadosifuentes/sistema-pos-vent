using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentSedes
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly SedeDaoMysql sedeDaoMysql;
        public ManagmentSedes()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.sedeDaoMysql = new SedeDaoMysql(gestorDaoMysql);
        }

        public DataTable ServiceGetAllSedes()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = sedeDaoMysql.DALGetAllSedes();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetSedePorNombre(string nombre)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = sedeDaoMysql.DALGetSedePorNombre(nombre);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ServiceInsertSede(Sede sede, string typeTransaction)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool state = sedeDaoMysql.DALInsertSede(sede, typeTransaction);
                if (state)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return state;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }
        public List<Sede> ServiceGetSedesEnCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Sede> listSedes = sedeDaoMysql.DALGetSedeEnCombo();
                gestorDaoMysql.connectionClose();
                return listSedes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Operation> ServiceListCajasAsignadasASede()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Operation> listSedes = sedeDaoMysql.DALListCajasAsignadasASede();
                gestorDaoMysql.connectionClose();
                return listSedes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
