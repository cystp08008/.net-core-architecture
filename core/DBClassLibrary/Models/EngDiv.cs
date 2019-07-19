using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class EngDiv
    {
        public EngDiv()
        {
            MemDiv = new HashSet<MemDiv>();
        }

        public string CengId { get; set; }
        public string CdivName { get; set; }
        public short BdivOrder { get; set; }
        public string Descrip { get; set; }
        public int? EngDivId { get; set; }
        public string Cfied0700 { get; set; }
        public string Cfied0800 { get; set; }
        public string Cfied1000 { get; set; }
        public string Csup0700 { get; set; }
        public string Csup0800 { get; set; }
        public string Csup1000 { get; set; }

        public virtual ICollection<MemDiv> MemDiv { get; set; }
    }
}
