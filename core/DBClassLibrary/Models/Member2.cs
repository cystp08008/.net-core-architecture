using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Member2
    {
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public bool? Ledit { get; set; }
        public string CSpec { get; set; }
        public decimal GrossWet { get; set; }
        public decimal PicWet { get; set; }
        public decimal MctWet { get; set; }
        public decimal GrossSiteWet { get; set; }
        public decimal PicSiteWet { get; set; }
        public decimal MctSiteWet { get; set; }
        public float Bmsurface1 { get; set; }
        public float BmsiteA1 { get; set; }
        public float Bmsurface2 { get; set; }
        public float BmsiteA2 { get; set; }
        public bool? LReCalWetArea { get; set; }
        public string CmaName { get; set; }
        public decimal BGrossWet { get; set; }
        public decimal BPicWet { get; set; }
        public decimal BMctWet { get; set; }
        public decimal BGrossSiteWet { get; set; }
        public decimal BPicSiteWet { get; set; }
        public decimal BMctSiteWet { get; set; }

        public virtual Member C { get; set; }
    }
}
