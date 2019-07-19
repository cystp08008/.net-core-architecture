using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Form
    {
        public Form()
        {
            FormRight = new HashSet<FormRight>();
            RptNavigation = new HashSet<Rpt>();
        }

        public string CfrmName { get; set; }
        public string CfrmDesp { get; set; }
        public string CPrgName { get; set; }
        public string CfrmVer { get; set; }
        public DateTime Atdate { get; set; }
        public DateTime Mtdate { get; set; }
        public bool? Enable { get; set; }
        public string CfrmNo { get; set; }
        public string Cnote { get; set; }
        public string CfrmgroupId { get; set; }
        public string CusrName { get; set; }
        public bool? Rpt { get; set; }

        public virtual FormGroup Cfrmgroup { get; set; }
        public virtual ICollection<FormRight> FormRight { get; set; }
        public virtual ICollection<Rpt> RptNavigation { get; set; }
    }
}
