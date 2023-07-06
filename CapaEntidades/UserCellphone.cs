using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class UserCellphone
    {
        public int CellPhoneId { get; set; }
        public string Number { get; set; }
        public User User { get; set; }
        public TipoOperador TipoOperador { get; set; }
    }
}
