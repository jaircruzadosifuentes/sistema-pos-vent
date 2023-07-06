using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentPresentacion
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly PresentacionDAOMysql presentacionDAOMysql;
        public ManagmentPresentacion()
        {
            gestorDaoMysql = new GestorDaoMysql();
            presentacionDAOMysql = new PresentacionDAOMysql(gestorDaoMysql);
        }
        public bool ServiceAnularPresentacion(int presentacionId)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool anula = presentacionDAOMysql.DALAnularPresentacion(presentacionId);
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
        public bool ServiceInsertaPresentacion(UMedida uMedida)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool inserta = presentacionDAOMysql.DALInsertaPresentacion(uMedida);
                if (inserta)
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
        public bool ServiceActualizaPresentacion(UMedida uMedida)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool actualiza = presentacionDAOMysql.DALActualizaPresentacion(uMedida);
                if (actualiza)
                {
                    gestorDaoMysql.finishTransaction();
                }
                else
                {
                    gestorDaoMysql.cancelTransaction();
                }
                return actualiza;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllPresentacionesEnDataTable()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = presentacionDAOMysql.GetAllPresentacionesEnDataTable();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServicePresentacionesAnuladas()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = presentacionDAOMysql.DALPresentacionesAnuladas();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetAllPresentacionPorNombre(string nombre)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = presentacionDAOMysql.DALGetAllPresentacionPorNombre(nombre);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
