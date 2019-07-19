using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TImpMaking
    {
        public string Qrykey { get; set; }
        public string CengId { get; set; }
        public string CmakId { get; set; }
        public string CmaName { get; set; }
        public string CuseId { get; set; }
        public bool? Lregular { get; set; }
        public bool? Lhole { get; set; }
        public bool? Lcut { get; set; }
        public bool? Lweld { get; set; }
        public bool? Lbend { get; set; }
        public string CmakDesp { get; set; }
        public float? Lcal1 { get; set; }
        public float? Lcal2 { get; set; }
        public decimal? NcutW { get; set; }
        public bool? Ltemplate { get; set; }
        public bool? Lsketch { get; set; }
        public bool? Lnc { get; set; }
        public bool? Lmodify { get; set; }
        public bool? Ledit { get; set; }
        public float? BcutA1 { get; set; }
        public float? BcutA2 { get; set; }
        public string CpaintId { get; set; }
        public bool? Linternal { get; set; }
        public string CmainId { get; set; }
        public bool? Lprint { get; set; }
        public string CSiteId { get; set; }
        public DateTime Cdate { get; set; }
        public int? ILine { get; set; }
        public string Lpic { get; set; }
    }
}
