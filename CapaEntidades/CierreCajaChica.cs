using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class CierreCajaChica
    {
        public int CierreCajaChicaId { get; set; }
        public decimal MontoAperturado { get; set; }
        public decimal MontoVendido { get; set; }
        public decimal MontoEgreso { get; set; }
        public decimal MontoEsperoEnCaja { get; set; }
        public string UsuarioReg { get; set; }
        public string OpeCod { get; set; }
        public Caja Caja { get; set; }
    }
}
