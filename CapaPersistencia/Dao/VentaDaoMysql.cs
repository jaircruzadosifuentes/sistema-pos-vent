using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class VentaDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public VentaDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public DataTable DALGetDetalleVentaPorId(int ventaId)
        {
            string comando = "stp_getDetalleVentaPorId";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmVentaId", ventaId)
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
        public DataTable DALGetVentaPorSerieNumero(string serieNumero)
        {
            string comando = "stp_GetVentaPorSerieNumero";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmSerieNumero", serieNumero)
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
        public DataTable DALGetVentaPorFiltro(int tipo, string filtro)
        {
            string comando = "stp_getVentasFiltro";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmTipo", tipo),
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
        public DataTable DALGetVentaPorId(int ventaId)
        {
            string comando = "stp_getVentaPorId";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("ventaId", ventaId),
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
        public DataTable DALGetVentaCreditoPorFiltro(int tipo, string filtro)
        {
            string comando = "stp_getVentasCreditosPorFiltro";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmTipo", tipo),
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
        public DataTable DALValidateStockProduct(int productId, decimal cantidad)
        {
            string comando = "stp_validarStockProducto";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmProductId", productId),
                new MySqlParameter("prmCantidad", cantidad),
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
        
        public DataTable DALGetAllVentas()
        {
            string comando = "stp_getAllVentas";
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
        public DataTable DALComprobantesParaCierreCajaChica(int cajaId, int sedeId)
        {
            string comando = "stp_getComprobantesParaCierreCajaChica";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmCajaId", cajaId),
                new MySqlParameter("prmSedeId", sedeId)
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
        public bool DALInsertaDetalleVenta(DetalleVenta detalleVenta, int ventaId)
        {
            MySqlCommand command = new MySqlCommand("stp_PostVentaDetalle");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmNIdProducto", detalleVenta.producto.ProductId);
                command.Parameters.AddWithValue("prmNCantidad", detalleVenta.cantidad);
                command.Parameters.AddWithValue("prmDCosto", detalleVenta.costo);
                command.Parameters.AddWithValue("prmNIdMovVenta", ventaId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DALInsertaVenta(Venta venta, string cOpeCod, string cMovNro)
        {
            MySqlCommand command = new MySqlCommand("stp_PostVenta");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmdSubTotal", venta.subTotal);
                command.Parameters.AddWithValue("prmdIgv", venta.igv);
                command.Parameters.AddWithValue("prmdTotal", venta.total);
                command.Parameters.AddWithValue("prmdVuelto", venta.vuelto);
                command.Parameters.AddWithValue("prmnTipoPagoId", venta.tipoPago.tipoPagoId);
                command.Parameters.AddWithValue("prmcOpeCod", cOpeCod);
                command.Parameters.AddWithValue("prmcMovNro", cMovNro);
                command.Parameters.AddWithValue("prmTipoTransaccion", venta.tipoTransaccion);
                command.Parameters.AddWithValue("prmCajaId", venta.Caja.CajaId);
                command.Parameters.AddWithValue("prmSedeId", venta.Sede.SedeId);
                command.Parameters.AddWithValue("prmClienteId", venta.Cliente.ClienteId);

                int index = Convert.ToInt32(command.ExecuteScalar().ToString());
                return index;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALInsertaMovVentaConcepto(VentaConcepto ventaConcepto, int ventaId)
        {
            MySqlCommand command = new MySqlCommand("stp_postVentaConcepto");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmConcepto", ventaConcepto.concepto);
                command.Parameters.AddWithValue("prmIdVenta", ventaId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DALRecuperaSerieCorrelativoVenta(int ventaId)
        {
            string comando = "stp_getSerieCorrelativoVenta";
            List<MySqlParameter> parametros = new List<MySqlParameter>
            {
                new MySqlParameter("prmVentaId", ventaId),
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
        public int DALExtornaVenta(int ventaId, string fechaModificacion, int cajaId, int sedeId, int usuarioId, string motivo)
        {
            MySqlCommand command = new MySqlCommand("stp_ExtornaVenta");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmintVentaId", ventaId);
                command.Parameters.AddWithValue("prm_fecha_modificacion", fechaModificacion);
                command.Parameters.AddWithValue("prmCajaId", cajaId);
                command.Parameters.AddWithValue("prmSedeId", sedeId);
                command.Parameters.AddWithValue("prmUsuarioId", usuarioId);
                command.Parameters.AddWithValue("prmMotivo", motivo);
                int index = Convert.ToInt32(command.ExecuteScalar().ToString());
                return index;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
