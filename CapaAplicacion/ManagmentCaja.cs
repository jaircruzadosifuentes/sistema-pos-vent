using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentCaja
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly CajaDaoMysql cajaDaoMysql;
        private readonly CajaChicaDaoMysql cajaChicaDaoMysql;
        public ManagmentCaja()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.cajaDaoMysql = new CajaDaoMysql(gestorDaoMysql);
            this.cajaChicaDaoMysql = new CajaChicaDaoMysql(gestorDaoMysql);
        }
        public bool GetStateOpenCaja(string gsUserName)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool state = cajaDaoMysql.GetStateOpenCaja(gsUserName);
                gestorDaoMysql.connectionClose();
                return state;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public bool ServiceVerificaCajaCerrada(string gsUserName, int cajaId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool state = cajaDaoMysql.DALVerificaCajaCerrada(gsUserName, cajaId);
                gestorDaoMysql.connectionClose();
                return state;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }
        public bool ServiceAperturaCajaChica(Apertura apertura)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool state = cajaChicaDaoMysql.DALAperturaCajaChica(apertura);
                gestorDaoMysql.connectionClose();
                return state;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        } 
        public bool ServiceRegistraEgresosEnCajaChica(Egreso egreso, string cMovNro)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool state = cajaChicaDaoMysql.DALRegistraEgresosEnCajaChica(egreso, cMovNro);
                gestorDaoMysql.connectionClose();
                return state;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }
        public bool ServiceRegistraPagoDeCredito(PagarCredito pagar, string cMovNro)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool state = cajaChicaDaoMysql.DALRegistraPagoDeCredito(pagar, cMovNro);
                if(state)
                {
                    gestorDaoMysql.finishTransaction();
                }
                else
                {
                    gestorDaoMysql.cancelTransaction();
                }
                return state;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }

        public bool ServiceCierreCajaChica(CierreCajaChica cierreCajaChica)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool state = cajaChicaDaoMysql.DALCierreCajaChica(cierreCajaChica);
                gestorDaoMysql.connectionClose();
                return state;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        } 
        public bool ServiceClosePettyCashForDay(CierreCajaChica closePettyCash)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool state = cajaChicaDaoMysql.DALClosePettyCashForDay(closePettyCash);
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
        public bool ServiceInsertCaja(Caja caja, string typeTransaction)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool state = cajaDaoMysql.DALInsertCaja(caja, typeTransaction);
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
        public bool ServiceDarDeBajaCaja(int cajaId)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool state = cajaDaoMysql.DALDarDeBajaCaja(cajaId);
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
        public List<Caja> ServiceGetCajaEnCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Caja> listCajas = cajaDaoMysql.DALGetCajaEnCombo();
                gestorDaoMysql.connectionClose();
                return listCajas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Caja> ServiceGetCajaPorSedeIdEnCombo(int sedeId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Caja> listCajas = cajaDaoMysql.DALGetCajaPorSedeIdEnCombo(sedeId);
                gestorDaoMysql.connectionClose();
                return listCajas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public List<Sede> ServiceGetSedesParaCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Sede> sedes = cajaDaoMysql.DALGetSedesParaCombo();
                gestorDaoMysql.connectionClose();
                return sedes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetMontoParaCajaChica(string codigoUsuario, int cajaId, int sedeId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALGetMontoParaCajaChica(codigoUsuario, cajaId, sedeId);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }     
        public DataTable ServiceVerificaCajasAsignadasASede(int sedeId, int cajaId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALVerificaCajasAsignadasASede(sedeId, cajaId);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }     
        public DataTable ServiceGetPagosPorVentaId(int ventaId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaChicaDaoMysql.DALGetPagosPorVentaId(ventaId);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }    
        public DataTable ServiceGetAllCajas()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALGetAllCajas();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }    
        public DataTable ServiceGetAllEgresosPorCodigoUsuario(string codigo_usuario)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaChicaDaoMysql.DALGetAllEgresosPorCodigoUsuario(codigo_usuario);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        public DataTable ServiceGetAllVentasConCreditos(int cajaId, int sedeId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaChicaDaoMysql.DALGetAllVentasConCreditos(cajaId, sedeId);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        public DataTable ServiceGetCajaPorNombre(string nombre)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALGetCajaPorNombre(nombre);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        public DataTable ServiceGetAllEgresos()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaChicaDaoMysql.DALGetAllEgresos();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        public DataTable ServiceGetMontoCreditoDeudas()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaChicaDaoMysql.DALGetMontoCreditoDeudas();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetCajasAperturadasConMonto()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALGetCajasAperturadasConMonto();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetCajaAperturadaPorFecha(DateTime dateTime)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALGetCajaAperturadaPorFecha(dateTime);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetCajaAperturadaPorCodigo(string userCode)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALGetCajaAperturadaPorCodigo(userCode);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ServiceGetOperationForCode(string userCode)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = cajaDaoMysql.DALGetOperationForCode(userCode);
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
