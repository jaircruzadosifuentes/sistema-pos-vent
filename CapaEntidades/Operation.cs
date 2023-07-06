using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Operation
    {
        public int OperationId { get; set; }
        public string IdentificationCode { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int State { get; set; }
        public string Raiz { get; set; }
        public string LastFechaModification { get; set; }
    }
}
