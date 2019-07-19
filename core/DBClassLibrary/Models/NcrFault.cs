using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrFault
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public int Ifault { get; set; }
        public int ImemQty { get; set; }

        public virtual NcrFaultName IfaultNavigation { get; set; }
        public virtual NcrTitle NcrTitle { get; set; }
    }
}
