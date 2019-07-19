using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtReturnD
    {
        public string WhnoI { get; set; }
        public string RepId { get; set; }
        public int Item { get; set; }
        public string MtNo { get; set; }
        public int? MtWidth { get; set; }
        public int? MtLen { get; set; }
        public int Qty { get; set; }
        public decimal? Wet { get; set; }
        public byte Ireturn { get; set; }
        public string StockNo { get; set; }
        public string WhengSoc { get; set; }
        public string WhengI { get; set; }
        public string StockPk { get; set; }
        public string TierI { get; set; }
        public string BelongI { get; set; }
        public string TierSoc { get; set; }
        public string BelongSoc { get; set; }

        public virtual MtMaterial MtNoNavigation { get; set; }
        public virtual MtReturnT MtReturnT { get; set; }
    }
}
