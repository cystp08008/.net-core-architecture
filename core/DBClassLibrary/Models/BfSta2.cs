using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class BfSta2
    {
        public string Repid { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CworkId { get; set; }
        public string CdivName { get; set; }
        public decimal IprtQty { get; set; }
        public DateTime? SprtDate { get; set; }
        public DateTime? EprtDate { get; set; }
        public DateTime? Cdate { get; set; }
    }
}
