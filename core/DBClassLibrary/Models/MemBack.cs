using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MemBack
    {
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CformId { get; set; }
        public decimal IprtQty { get; set; }
        public DateTime ProDate { get; set; }
        public int Iorder { get; set; }
        public string CusrName { get; set; }
        public decimal? BWet { get; set; }
        public float? BSurface1 { get; set; }
        public float? BSurface2 { get; set; }

        public virtual FbForm C { get; set; }
    }
}
