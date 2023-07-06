using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.gVarPublicas
{
    public class GVarPublicas
    {
        public static int GsUserId { get; set; }
        public static string GsUserName { get; set; }
        public static string GsMonedaDefault { get; set; }
        public static string GsCaja { get; set; }
        public static string GsSede { get; set; }
        public static int GsSedeId { get; set; }
        public static string GsRuc { get; set; }
        public static int GsCajaId { get; set; }
        public static string GsCargo { get; set; }

        //Operaciones
        public const string gProductosAnulados = "500001";
        public const string gTrabajadoresAnulados = "500003";
        public const string gCategoriasAnulados = "500004";
        public const string gPresentacionesAnuladas = "500005";
        public const string gRegistroCajas = "510011";
        public const string gRegistroSedes = "510012";
        public const string gAsignacionCajaSede = "510013";
        public const string gAperturaCajaChica = "510020";
        public const string gRegistroIngreso = "520201";
        public const string gListadoDeIngresosEnCajaChica = "520202";
        public const string gCierreDeCajaChica = "510030";
        public const string gListaoDeCajasAperturadas = "510040";
        public const string gRegistroEgresos = "520001";
        public const string gListadoDeEgresos = "520003";
        public const string gPagosPendientesPorCobrar = "520102";
        public const string gEmitirPagoPendiente = "520101";
        public const string gExtornarVenta = "520203";
    }
}
