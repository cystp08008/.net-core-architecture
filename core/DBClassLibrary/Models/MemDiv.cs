using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MemDiv
    {
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CdivName { get; set; }
        public int IdivQty { get; set; }
        public DateTime? GoalDate { get; set; }
        public DateTime? Dtlayout { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string Cfied0700 { get; set; }
        public string Csup0700 { get; set; }
        public string Cfied0800 { get; set; }
        public string Csup0800 { get; set; }
        public string Cfied1000 { get; set; }
        public string Csup1000 { get; set; }

        public virtual EngDiv C { get; set; }
        public virtual Member CNavigation { get; set; }
    }
}
