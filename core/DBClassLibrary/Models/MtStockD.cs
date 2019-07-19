using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtStockD
    {
        public string StockPk { get; set; }
        public string Wheng { get; set; }
        public int? Qty { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string Tier { get; set; }
        public string Belong { get; set; }
        public string Slocate { get; set; }

        public virtual MtStockT StockPkNavigation { get; set; }
        public virtual MtEng WhengNavigation { get; set; }
    }
}
