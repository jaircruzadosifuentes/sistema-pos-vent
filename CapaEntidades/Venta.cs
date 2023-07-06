using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Venta
    {
        public int ventaId { get; set; }
        public decimal vuelto { get; set; }
        public decimal subTotal { get; set; }
        public decimal igv { get; set; }
        public decimal total { get; set; }
        public TipoPago tipoPago { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        public VentaConcepto ventaConcepto { get; set; }
        public bool tieneConcepto { get; set; }
        public string tipoTransaccion { get; set; }
        public Caja Caja { get; set; }
        public Sede Sede { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Hora { get; set; }
        public string Usuario { get; set; }
        public string Correlativo { get; set; }
        public Venta()
        {
            DetalleVentas = new List<DetalleVenta>();
        }
    }
}
