using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class CutDistTitle
    {
        public CutDistTitle()
        {
            CutDistBom = new HashSet<CutDistBom>();
            CutDistDetail = new HashSet<CutDistDetail>();
            CutDistShape = new HashSet<CutDistShape>();
        }

        public string CengId { get; set; }
        public string RepId { get; set; }
        public string Cdescp { get; set; }
        public DateTime Cdate { get; set; }
        public float? Lossrate { get; set; }
        public float? CutLoss { get; set; }
        public decimal? LenRem { get; set; }
        public decimal? EdgeLen { get; set; }

        public virtual ICollection<CutDistBom> CutDistBom { get; set; }
        public virtual ICollection<CutDistDetail> CutDistDetail { get; set; }
        public virtual ICollection<CutDistShape> CutDistShape { get; set; }
    }
}
