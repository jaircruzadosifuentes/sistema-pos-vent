using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentVenta
    {
        private readonly VentaDaoMysql ventaDaoMysql;
        private readonly GestorDaoMysql gestorDaoMysql;
        public ManagmentVenta()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.ventaDaoMysql = new VentaDaoMysql(gestorDaoMysql);
        }
        public DataTable ServiceGetAllVentas()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = ventaDaoMysql.DALGetAllVentas();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceComprobantesParaCierreCajaChica(int cajaId, int sedeId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = ventaDaoMysql.DALComprobantesParaCierreCajaChica(cajaId, sedeId);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        public DataTable ServiceGetVentaPorFiltro(int tipo, string filtro)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = ventaDaoMysql.DALGetVentaPorFiltro(tipo, filtro);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetVentaCreditoPorFiltro(int tipo, string filtro)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = ventaDaoMysql.DALGetVentaCreditoPorFiltro(tipo, filtro);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetDetalleVentaPorId(int ventaId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = ventaDaoMysql.DALGetDetalleVentaPorId(ventaId);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetVentaPorSerieNumero(string serieNumero)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = ventaDaoMysql.DALGetVentaPorSerieNumero(serieNumero);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetVentaPorId(int ventaId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = ventaDaoMysql.DALGetVentaPorId(ventaId);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ServiceInsertMovVentaConcepto(VentaConcepto ventaConcepto, int ventaId)
        {
            try
            {
                return ventaDaoMysql.DALInsertaMovVentaConcepto(ventaConcepto, ventaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceValidateStockProduct(int productId, decimal cantidad)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable dtResults = ventaDaoMysql.DALValidateStockProduct(productId, cantidad);
                gestorDaoMysql.connectionClose();
                return dtResults;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }
        public string InsertaVenta(Venta venta, string cOpeCod, string cMovNro)
        {
            try
            {
                bool inserta = false;
                int ventaId = 0;
                string cNroCorrelativo = "";
                gestorDaoMysql.startTransaction();
                ventaId = ventaDaoMysql.DALInsertaVenta(venta, cOpeCod, cMovNro);
                if(ventaId == 0)
                {
                    gestorDaoMysql.cancelTransaction();
                    return cNroCorrelativo;
                }
                foreach (DetalleVenta detalleVenta in venta.DetalleVentas)
                {
                    inserta = ventaDaoMysql.DALInsertaDetalleVenta(detalleVenta, ventaId);
                }
                //Verificamos si hay concepto
                if(venta.tieneConcepto)
                {
                    bool insertaConcepto = ServiceInsertMovVentaConcepto(venta.ventaConcepto, ventaId);
                    if (!insertaConcepto)
                    {
                        gestorDaoMysql.cancelTransaction();
                        return cNroCorrelativo;
                    }
                }
                if(!inserta)
                {
                    gestorDaoMysql.cancelTransaction();
                    return cNroCorrelativo;
                }
                //Recuperamos la serie y correlativo
                gestorDaoMysql.finishTransaction();
                gestorDaoMysql.connectionOpen();
                cNroCorrelativo = ServiceRecuperaSerieVenta(ventaId);
                gestorDaoMysql.connectionClose();
                return cNroCorrelativo;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }

        private string ServiceRecuperaSerieVenta(int ventaId)
        {
            try
            {
                DataTable dt = ventaDaoMysql.DALRecuperaSerieCorrelativoVenta(ventaId);
                return dt.Rows[0]["serie"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ServiceExtornaVenta(int ventaId, string fechaModificacion, int cajaId, int sedeId, int usuarioId, string motivo)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                int extorna = ventaDaoMysql.DALExtornaVenta(ventaId, fechaModificacion, cajaId, sedeId, usuarioId, motivo);
                if(extorna == 0)
                {
                    gestorDaoMysql.cancelTransaction();
                }
                gestorDaoMysql.finishTransaction();
                return extorna > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
