using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class TipoDocumento
    {
        public int TipoDocumentoId { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public int Tamanio { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
