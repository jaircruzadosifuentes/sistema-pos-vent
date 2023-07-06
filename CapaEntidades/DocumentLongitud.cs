using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class DocumentLongitud
    {
        public int DocumentLongitudId { get; set; }
        public int Serie { get; set; }
        public int Number { get; set; }
        public Document Document { get; set; }
        public string LastDateModification { get; set; }
    }
}
