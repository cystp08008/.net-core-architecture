using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MemberFlag
    {
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string RptChg { get; set; }
        public string RptRfb { get; set; }
        public string RptNcr { get; set; }
        public string RptLayout { get; set; }
        public string RptSp { get; set; }

        public virtual Member C { get; set; }
    }
}
