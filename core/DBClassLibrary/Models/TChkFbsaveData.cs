using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TChkFbsaveData
    {
        public int Rnum { get; set; }
        public int Num { get; set; }
        public int? Type { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public decimal? Qty { get; set; }
        public string Message { get; set; }
        public int? Flow { get; set; }
    }
}
