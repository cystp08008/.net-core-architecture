using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class QaStatus
    {
        public DateTime DSign { get; set; }
        public string RepId { get; set; }
        public int? IwfId { get; set; }
        public int IflowId { get; set; }
        public string CusrName { get; set; }
        public string CDepId { get; set; }

        public virtual Qa Rep { get; set; }
    }
}
