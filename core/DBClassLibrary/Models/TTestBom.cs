using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TTestBom
    {
        public int Randvalue { get; set; }
        public int ILineNo { get; set; }
        public string CmemId { get; set; }
        public int? ImemQty { get; set; }
        public string CmakId { get; set; }
        public string Cspec { get; set; }
        public int? IbomQty { get; set; }
        public string CmaName { get; set; }
        public decimal? Nweight { get; set; }
        public decimal? Totalweight { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CmemPic { get; set; }
        public string CengId { get; set; }
        public string CuseId { get; set; }
    }
}
