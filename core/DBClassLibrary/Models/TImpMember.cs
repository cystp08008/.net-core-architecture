using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TImpMember
    {
        public string Qrykey { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CpaintId { get; set; }
        public string CflowId { get; set; }
        public float? BmcutW { get; set; }
        public float? BmcutA1 { get; set; }
        public float? BmcutA2 { get; set; }
        public DateTime? Cdate { get; set; }
        public int? ILine { get; set; }
        public string Dssnote { get; set; }
        public string Pcsnote { get; set; }
        public string Qsanote { get; set; }
        public string Stsnote { get; set; }
    }
}
