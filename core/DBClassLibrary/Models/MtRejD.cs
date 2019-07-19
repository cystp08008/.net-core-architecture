using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtRejD
    {
        public string RepId { get; set; }
        public string StockNo { get; set; }
        public int? Qty { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual MtRejT Rep { get; set; }
    }
}
