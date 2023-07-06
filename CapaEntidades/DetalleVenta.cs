using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        public int detalleVentaId { get; set; }
        public Product producto { get; set; }
        public decimal cantidad { get; set; }
        public decimal costo { get; set; }
        public Venta venta { get; set; }
    }
}
