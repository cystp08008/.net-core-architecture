using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class CutDistShape
    {
        public CutDistShape()
        {
            CutDistDetail = new HashSet<CutDistDetail>();
        }

        public string CengId { get; set; }
        public string RepId { get; set; }
        public int ShapNo { get; set; }
        public string CSpec { get; set; }
        public decimal Nlen { get; set; }
        public string CmaName { get; set; }
        public decimal Bweight { get; set; }
        public decimal? NlenRem { get; set; }
        public float? LossRate { get; set; }

        public virtual CutDistTitle CutDistTitle { get; set; }
        public virtual ICollection<CutDistDetail> CutDistDetail { get; set; }
    }
}
