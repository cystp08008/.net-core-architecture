using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtPurchT
    {
        public MtPurchT()
        {
            MtPurchD = new HashSet<MtPurchD>();
        }

        public string RepId { get; set; }
        public string CengId { get; set; }
        public string Tier { get; set; }
        public string Belong { get; set; }
        public DateTime? Pdate { get; set; }
        public DateTime? Ddate { get; set; }
        public DateTime? Dlvdt { get; set; }
        public string Dlvdp { get; set; }
        public string Etpco { get; set; }
        public DateTime? Cdate { get; set; }
        public string EmpId { get; set; }
        public string Enoin { get; set; }

        public virtual ICollection<MtPurchD> MtPurchD { get; set; }
    }
}
