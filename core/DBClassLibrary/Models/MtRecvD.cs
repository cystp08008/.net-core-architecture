using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtRecvD
    {
        public string RepId { get; set; }
        public string Whno { get; set; }
        public int Item { get; set; }
        public int Qty { get; set; }
        public string Wet { get; set; }
        public string MtNo { get; set; }
        public int? MtWidth { get; set; }
        public int? MtLen { get; set; }
        public string PurUnit { get; set; }
        public string PurRepId { get; set; }
        public int PurItem { get; set; }
        public string StockPk { get; set; }
        public string StockNo { get; set; }
        public string Tier { get; set; }
        public string Belong { get; set; }

        public virtual MtRecvT MtRecvT { get; set; }
    }
}
