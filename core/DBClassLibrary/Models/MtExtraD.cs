using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtExtraD
    {
        public string RepId { get; set; }
        public string Whno { get; set; }
        public int Item { get; set; }
        public string StockPk { get; set; }
        public int? Qty { get; set; }
        public decimal? Wet { get; set; }
        public string WhengSoc { get; set; }
        public string TierSoc { get; set; }
        public string BelongSoc { get; set; }
        public string MtNo { get; set; }

        public virtual MtExtraT MtExtraT { get; set; }
    }
}
