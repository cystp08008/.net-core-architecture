using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtPurchD
    {
        public string RepId { get; set; }
        public int IItem { get; set; }
        public string MtNo { get; set; }
        public int? MtWide { get; set; }
        public int? MtLen { get; set; }
        public int? Qty { get; set; }
        public string ContNo { get; set; }
        public string ContType { get; set; }
        public int? ContItem { get; set; }
        public DateTime? Dlvdt { get; set; }
        public decimal? MtWet { get; set; }
        public string WetUid { get; set; }

        public virtual MtPurchT Rep { get; set; }
    }
}
