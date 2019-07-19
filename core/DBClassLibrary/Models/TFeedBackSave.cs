using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TFeedBackSave
    {
        public int Rnum { get; set; }
        public int Num { get; set; }
        public int? Type { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public decimal? Qty { get; set; }
        public bool? Lcheck { get; set; }
        public bool? Lbom { get; set; }
        public bool? IsBf { get; set; }
        public string CdivName { get; set; }
        public decimal? Wet { get; set; }
    }
}
