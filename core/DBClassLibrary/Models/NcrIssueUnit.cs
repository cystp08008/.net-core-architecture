using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrIssueUnit
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CDepId { get; set; }
        public bool Lneedfb { get; set; }
        public string Cdisp { get; set; }
        public bool Lappendix { get; set; }
        public bool? Lfb { get; set; }
        public DateTime Cdate { get; set; }
        public DateTime Ddist { get; set; }

        public virtual NcrTitle NcrTitle { get; set; }
    }
}
