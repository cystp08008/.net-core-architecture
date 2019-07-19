using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrStrategy
    {
        public NcrStrategy()
        {
            NcrStrategyStatus = new HashSet<NcrStrategyStatus>();
        }

        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CDepId { get; set; }
        public bool Lappendix { get; set; }
        public string Canalysis { get; set; }
        public string Cstrategy { get; set; }
        public DateTime Cdate { get; set; }
        public int IflowId { get; set; }

        public virtual NcrTitle NcrTitle { get; set; }
        public virtual ICollection<NcrStrategyStatus> NcrStrategyStatus { get; set; }
    }
}
