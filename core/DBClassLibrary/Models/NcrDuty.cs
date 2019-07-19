using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrDuty
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CDepId { get; set; }
        public string CsupId { get; set; }
        public decimal Bproportion { get; set; }
        public bool? Lagree { get; set; }
        public decimal? Nwastage { get; set; }

        public virtual NcrTitle NcrTitle { get; set; }
    }
}
