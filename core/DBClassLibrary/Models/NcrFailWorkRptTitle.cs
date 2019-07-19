using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrFailWorkRptTitle
    {
        public NcrFailWorkRptTitle()
        {
            NcrFailWorkRptDetail = new HashSet<NcrFailWorkRptDetail>();
        }

        public string Id { get; set; }
        public string CengId { get; set; }
        public DateTime? Cdate { get; set; }
        public decimal? Price { get; set; }
        public string CusrName { get; set; }
        public string Cnote { get; set; }

        public virtual ICollection<NcrFailWorkRptDetail> NcrFailWorkRptDetail { get; set; }
    }
}
