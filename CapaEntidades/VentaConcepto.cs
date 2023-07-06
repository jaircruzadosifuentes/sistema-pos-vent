using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class VentaConcepto
    {
        public int ventaConceptoId { get; set; }
        public string concepto { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int estado { get; set; }
        public Venta venta { get; set; }
    }
}
