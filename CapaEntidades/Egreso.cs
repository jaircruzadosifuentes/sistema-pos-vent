using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Egreso
    {
        public int EgresoId { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string CodigoOperacion { get; set; }
        public Caja Caja { get; set; }
        public Sede Sede { get; set; }
        public User Usuario { get; set; }
        public bool Estado { get; set; }
    }
}
