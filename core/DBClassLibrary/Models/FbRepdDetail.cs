using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class FbRepdDetail
    {
        public FbRepdDetail()
        {
            BfSta = new HashSet<BfSta>();
        }

        public string RepId { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CmemPic { get; set; }
        public int ChgId { get; set; }
        public bool IsFebk { get; set; }
        public bool IsStp { get; set; }
        public bool B0700 { get; set; }
        public bool B0800 { get; set; }
        public bool B0900 { get; set; }
        public bool B1000 { get; set; }
        public bool B1100 { get; set; }
        public decimal? BWet { get; set; }
        public float? BSurface1 { get; set; }
        public float? BSurfae2 { get; set; }

        public virtual FbRepdTitle FbRepdTitle { get; set; }
        public virtual ICollection<BfSta> BfSta { get; set; }
    }
}
