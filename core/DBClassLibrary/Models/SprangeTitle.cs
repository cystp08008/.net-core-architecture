using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SprangeTitle
    {
        public SprangeTitle()
        {
            SpFunSta = new HashSet<SpFunSta>();
            SpfunTitle = new HashSet<SpfunTitle>();
            SprangeDetail = new HashSet<SprangeDetail>();
            SprangeMem = new HashSet<SprangeMem>();
        }

        public string CengId { get; set; }
        public string CRangeId { get; set; }
        public string Cdescp { get; set; }
        public int? IRangeType { get; set; }
        public DateTime Cdate { get; set; }
        public string CusrName { get; set; }
        public bool LRptOk { get; set; }
        public int? IQryType { get; set; }
        public int? IRptGrp { get; set; }
        public DateTime? DRecv { get; set; }

        public virtual ICollection<SpFunSta> SpFunSta { get; set; }
        public virtual ICollection<SpfunTitle> SpfunTitle { get; set; }
        public virtual ICollection<SprangeDetail> SprangeDetail { get; set; }
        public virtual ICollection<SprangeMem> SprangeMem { get; set; }
    }
}
