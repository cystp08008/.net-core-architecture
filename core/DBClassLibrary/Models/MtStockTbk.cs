using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtStockTbk
    {
        public MtStockTbk()
        {
            MtStockDbk = new HashSet<MtStockDbk>();
        }

        public string StockPk { get; set; }
        public string Whno { get; set; }
        public string StockNo { get; set; }
        public string MtNo { get; set; }
        public int? MtWidth { get; set; }
        public int? MtLen { get; set; }
        public decimal? Wet { get; set; }
        public string WhengFst { get; set; }
        public string WhengRtn { get; set; }
        public DateTime? StDate { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public byte? MtType { get; set; }
        public string Tier { get; set; }
        public string Belong { get; set; }
        public DateTime? AdjDate { get; set; }
        public int Bkno { get; set; }

        public virtual ICollection<MtStockDbk> MtStockDbk { get; set; }
    }
}
