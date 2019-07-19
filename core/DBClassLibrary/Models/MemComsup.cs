using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MemComsup
    {
        public string CengId { get; set; }
        public string CsupId { get; set; }
        public string CmemId { get; set; }
        public string CworkId { get; set; }
        public decimal? ImemQty { get; set; }

        public virtual Member C { get; set; }
        public virtual Comsup Csup { get; set; }
    }
}
