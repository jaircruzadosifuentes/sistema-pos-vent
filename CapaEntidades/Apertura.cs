using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Apertura
    {
        public string codigoUsuario { get; set; }
        public decimal montoApertura { get; set; }
        public DateTime fechaApertura { get; set; }

        public int cajaId { get; set; }
        public int sedeId { get; set; }
    }
}
