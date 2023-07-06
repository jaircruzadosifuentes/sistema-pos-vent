using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class CajaChicaDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public CajaChicaDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }
        public bool DALCierreCajaChica(CierreCajaChica cierreCajaChica)
        {
            MySqlCommand command = new MySqlCommand("stp_post_cierre_caja_dia_actual");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmMontoAperturado", cierreCajaChica.MontoAperturado);
                command.Parameters.AddWithValue("prmMontoVendido", cierreCajaChica.MontoVendido);
                command.Parameters.AddWithValue("prmMontoEgreso", cierreCajaChica.MontoEgreso);
                command.Parameters.AddWithValue("prmMontoEsperado", cierreCajaChica.MontoEsperoEnCaja);
                command.Parameters.AddWithValue("prmcUsuarioReg", cierreCajaChica.UsuarioReg);
                command.Parameters.AddWithValue("prmcOpeCod", cierreCajaChica.OpeCod);
                command.Parameters.AddWithValue("prmCajaId", cierreCajaChica.Caja.CajaId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALClosePettyCashForDay(CierreCajaChica closePettyCash)
        {
            MySqlCommand command = new MySqlCommand("stp_post_close_pettycash_for_day");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prm_operation_pettycash_id", closePettyCash.CierreCajaChicaId);
                command.Parameters.AddWithValue("prm_open_amount", closePettyCash.MontoAperturado);
                command.Parameters.AddWithValue("prm_amount_sold", closePettyCash.MontoVendido);
                command.Parameters.AddWithValue("prm_expense_amount", closePettyCash.MontoEgreso);
                command.Parameters.AddWithValue("prm_expected_amount", closePettyCash.MontoEsperoEnCaja);
                command.Parameters.AddWithValue("prm_user_reg", closePettyCash.UsuarioReg);
                command.Parameters.AddWithValue("prm_code_operation", closePettyCash.OpeCod);
                command.Parameters.AddWithValue("prm_cash_id", closePettyCash.Caja.CajaId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DALAperturaCajaChica(Apertura apertura)
        {
            MySqlCommand command = new MySqlCommand("stp_aperturaCajaChica");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmCodigoUsuario", apertura.codigoUsuario);
                command.Parameters.AddWithValue("prmMontoApertura", apertura.montoApertura);
                command.Parameters.AddWithValue("prmFechaApertura", apertura.fechaApertura);
                command.Parameters.AddWithValue("prmCajaId", apertura.cajaId);
                command.Parameters.AddWithValue("prmSedeId", apertura.sedeId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Egresos
        public bool DALRegistraEgresosEnCajaChica(Egreso egreso, string cMovNro)
        {
            MySqlCommand command = new MySqlCommand("stp_registra_egreso");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmDescripcion", egreso.Descripcion);
                command.Parameters.AddWithValue("prmMonto", egreso.Monto);
                command.Parameters.AddWithValue("prmCajaId", egreso.Caja.CajaId);
                command.Parameters.AddWithValue("prmSedeId", egreso.Sede.SedeId);
                command.Parameters.AddWithValue("prmUsuarioId", egreso.Usuario.UserId);
                command.Parameters.AddWithValue("prmOpeCod", egreso.CodigoOperacion);
                command.Parameters.AddWithValue("prmCMovNro", cMovNro);
                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Pagar crédito
        public bool DALRegistraPagoDeCredito(PagarCredito pagarCredito, string cMovNro)
        {
            MySqlCommand command = new MySqlCommand("stp_pagar_credito");
            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmMonto", pagarCredito.Monto);
                command.Parameters.AddWithValue("prmUsuario", cMovNro);
                command.Parameters.AddWithValue("prmCodigoOperacion", pagarCredito.CodigoOperacion);
                command.Parameters.AddWithValue("prmMovVentaId", pagarCredito.Venta.ventaId);
                command.Parameters.AddWithValue("prmDescripcion", pagarCredito.Descripcion);
                command.Parameters.AddWithValue("prmSedeId", pagarCredito.Sede.SedeId);
                command.Parameters.AddWithValue("prmCajaId", pagarCredito.Caja.CajaId);

                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DALGetAllEgresos()
        {
            string comando = "stp_getAllEgresos";
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
        public DataTable DALGetAllEgresosPorCodigoUsuario(string codigoUsuario)
        {
            string comando = "stp_getAllEgresoPorCodigoUsuario";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("codigo_usuario", codigoUsuario),
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
        public DataTable DALGetMontoCreditoDeudas()
        {
            string comando = "stp_getMontoCreditoDeudas";

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

        public DataTable DALGetAllVentasConCreditos(int cajaId, int sedeId)
        {
            string comando = "stp_getAllVentasCreditos";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmCajaId", cajaId),
                new MySqlParameter("prmSedeId", sedeId),
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
        public DataTable DALGetPagosPorVentaId(int ventaId)
        {
            string comando = "stpGetDetallePagoPorIdVenta";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("prmVentaId", ventaId),
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
