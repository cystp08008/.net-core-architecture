using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrFailWorkRptDetail
    {
        public string Id { get; set; }
        public string CengId { get; set; }
        public string RepId { get; set; }
        public decimal? H1 { get; set; }
        public decimal? H2 { get; set; }
        public decimal? H3 { get; set; }
        public decimal? H4 { get; set; }
        public string Cfailwork { get; set; }
        public string Cnote { get; set; }

        public virtual NcrFailWorkRptTitle NcrFailWorkRptTitle { get; set; }
    }
}
