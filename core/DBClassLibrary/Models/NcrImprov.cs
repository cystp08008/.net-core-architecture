using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrImprov
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CDepId { get; set; }
        public string Cimprov { get; set; }
        public DateTime? Ddist { get; set; }
        public DateTime? Cdate { get; set; }
        public bool? Lappendix { get; set; }

        public virtual NcrTitle NcrTitle { get; set; }
    }
}
