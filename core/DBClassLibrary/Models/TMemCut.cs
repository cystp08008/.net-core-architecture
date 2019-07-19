using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TMemCut
    {
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CmemId { get; set; }
        public string CdivName { get; set; }
        public string CmemPic { get; set; }
        public int? Qty { get; set; }
        public decimal? Memwet { get; set; }
        public float? BmcutW { get; set; }
        public float? Bmsurface1 { get; set; }
        public float? BmcutA1 { get; set; }
        public float? Bmsurface2 { get; set; }
        public float? BmcutA2 { get; set; }
        public float? NcutW { get; set; }
        public float? BcutA1 { get; set; }
        public float? BcutA2 { get; set; }
        public string CSpec { get; set; }
    }
}
