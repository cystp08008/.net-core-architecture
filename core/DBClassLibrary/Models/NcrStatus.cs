using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrStatus
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public int Stage { get; set; }
        public string CDepId { get; set; }
        public int SignOrder { get; set; }
        public string CusrName { get; set; }
        public DateTime? DSign { get; set; }

        public virtual NcrTitle NcrTitle { get; set; }
    }
}
