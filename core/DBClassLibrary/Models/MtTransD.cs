using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtTransD
    {
        public string RepId { get; set; }
        public string Whno { get; set; }
        public string StockPk { get; set; }
        public string ActNo { get; set; }
        public int Item { get; set; }
        public int Qty { get; set; }
        public string Wheng { get; set; }
        public string Tier { get; set; }
        public string Belong { get; set; }
        public string MtNo { get; set; }
        public decimal? Wet { get; set; }

        public virtual MtTransT MtTransT { get; set; }
    }
}
