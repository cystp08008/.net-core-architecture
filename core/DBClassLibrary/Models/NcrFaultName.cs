using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrFaultName
    {
        public NcrFaultName()
        {
            NcrFault = new HashSet<NcrFault>();
        }

        public int Ifault { get; set; }
        public string CName { get; set; }

        public virtual ICollection<NcrFault> NcrFault { get; set; }
    }
}
