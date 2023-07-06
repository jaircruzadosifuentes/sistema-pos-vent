using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NroDocumento { get; set; }
        public bool TieneCorreo { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public char Sexo { get; set; }
        public string DireccionFiscal { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Estado { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}
