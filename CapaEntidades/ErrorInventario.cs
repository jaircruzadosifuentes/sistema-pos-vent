using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class ErrorInventario
    {
        public int ErrorInventarioId { get; set; }
        public string Nombre { get; set; }
        public int NroRegistro { get; set; }
        public string Columna { get; set; }
        public string Valor { get; set; }
    }
}
