using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtStockDbk
    {
        public string StockPk { get; set; }
        public string Wheng { get; set; }
        public int? Qty { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string Tier { get; set; }
        public string Belong { get; set; }
        public int Bkno { get; set; }

        public virtual MtStockTbk MtStockTbk { get; set; }
    }
}
