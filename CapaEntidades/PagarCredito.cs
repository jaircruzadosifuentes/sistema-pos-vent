using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class PagarCredito
    {
        public int PagarCreditoId { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public string CodigoOperacion { get; set; }
        public bool Estado { get; set; }
        public Venta Venta { get; set; }
        public Sede Sede { get; set; }
        public Caja Caja { get; set; }
    }
}
