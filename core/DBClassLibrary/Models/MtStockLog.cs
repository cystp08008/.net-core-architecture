using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtStockLog
    {
        public string StockPk { get; set; }
        public string ActNo { get; set; }
        public string RepId { get; set; }
        public int? QtyInc { get; set; }
        public int? QtyDec { get; set; }
        public DateTime? Cdate { get; set; }
        public string EmpId { get; set; }
        public long LogPk { get; set; }
        public string Wheng { get; set; }
    }
}
