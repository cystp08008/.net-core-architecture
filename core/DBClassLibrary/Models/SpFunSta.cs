using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SpFunSta
    {
        public SpFunSta()
        {
            SpfunRpt = new HashSet<SpfunRpt>();
        }

        public string CengId { get; set; }
        public string CRangeId { get; set; }
        public string CmakId { get; set; }
        public int? Iqty { get; set; }
        public string OrgRangeId { get; set; }
        public string CmemPic { get; set; }
        public string CSiteId { get; set; }
        public int? RQty { get; set; }
        public long FunRptId { get; set; }

        public virtual SprangeTitle C { get; set; }
        public virtual ICollection<SpfunRpt> SpfunRpt { get; set; }
    }
}
