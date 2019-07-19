using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrFeedBack
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CDepId { get; set; }
        public decimal? NworkH { get; set; }
        public decimal? Nwastage { get; set; }
        public int IWorkStation { get; set; }

        public virtual NcrWorkStation IWorkStationNavigation { get; set; }
        public virtual NcrTitle NcrTitle { get; set; }
    }
}
