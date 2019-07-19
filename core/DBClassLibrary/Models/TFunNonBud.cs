using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TFunNonBud
    {
        public string CmakId { get; set; }
        public string CmakDesp { get; set; }
        public string CmaName { get; set; }
        public int? Iqty { get; set; }
        public int? Rqty { get; set; }
        public long Funrptid { get; set; }
        public string OrgRangeid { get; set; }
        public string Strtype { get; set; }
        public decimal? Dim1 { get; set; }
        public decimal? Dim2 { get; set; }
        public decimal? Dim3 { get; set; }
    }
}
