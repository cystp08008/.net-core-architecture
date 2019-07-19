using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TRptMakingQry
    {
        public long Pk { get; set; }
        public int Num { get; set; }
        public string CmakId { get; set; }
        public string Cspec { get; set; }
        public string CmaName { get; set; }
        public string CuseId { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CmemPic { get; set; }
        public string CmemId { get; set; }
        public int? ImemQty { get; set; }
        public int? ImakQty { get; set; }
        public int? IqtyCount { get; set; }
        public bool? Lcheck { get; set; }
    }
}
