using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Rpt
    {
        public string RptId { get; set; }
        public string RptDesp { get; set; }
        public int RptType { get; set; }
        public int RptSort { get; set; }
        public string CfrmName { get; set; }

        public virtual Form CfrmNameNavigation { get; set; }
    }
}
