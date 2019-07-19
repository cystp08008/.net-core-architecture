using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SprangeDetail
    {
        public string CengId { get; set; }
        public string CRangeId { get; set; }
        public string CmemId { get; set; }
        public string CdivName { get; set; }
        public string CmakId { get; set; }
        public int IQty { get; set; }
        public decimal? Nweight { get; set; }
        public string Cspec { get; set; }
        public string CmakDesp { get; set; }
        public string CmemPic { get; set; }
        public string CbelongId { get; set; }
        public string CtierName { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual SprangeTitle C { get; set; }
    }
}
