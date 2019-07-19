using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Member2WareH
    {
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string VerName { get; set; }
        public bool Ledit { get; set; }
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
        public string CmaName { get; set; }

        public virtual MemberWareH MemberWareH { get; set; }
    }
}
