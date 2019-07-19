using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class BfSta
    {
        public string RepId { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CworkId { get; set; }
        public decimal IprtQty { get; set; }
        public DateTime? SprtDate { get; set; }
        public DateTime? EprtDate { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual FbRepdDetail FbRepdDetail { get; set; }
    }
}
