using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrStrategyStatus
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public int IflowId { get; set; }
        public string CDepId { get; set; }
        public DateTime Dconf { get; set; }
        public string CusrName { get; set; }
        public string NcrDep { get; set; }

        public virtual NcrStrategy NcrStrategy { get; set; }
    }
}
