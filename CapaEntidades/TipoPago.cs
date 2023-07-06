using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class TipoPago
    {
        public int tipoPagoId { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }
        public int pideConcepto { get; set; }
    }
}
