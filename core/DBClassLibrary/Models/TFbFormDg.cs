using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TFbFormDg
    {
        public string CmemId { get; set; }
        public string CengId { get; set; }
        public int ImemQty { get; set; }
        public int BackQty { get; set; }
        public int? CanBackQty { get; set; }
        public int? IQty { get; set; }
        public decimal? Wet { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public float? Bsa1 { get; set; }
        public float? Bsa2 { get; set; }
        public int Iorder { get; set; }
        public string CmemPic { get; set; }
        public DateTime? ProDate { get; set; }
        public string CdivName { get; set; }
    }
}
