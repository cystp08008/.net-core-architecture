using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtExtraT
    {
        public MtExtraT()
        {
            MtExtraD = new HashSet<MtExtraD>();
        }

        public string RepId { get; set; }
        public string Whno { get; set; }
        public DateTime? Edate { get; set; }
        public string ActNo { get; set; }
        public string WhengExt { get; set; }
        public string Tier { get; set; }
        public string Belong { get; set; }
        public string ComMf { get; set; }
        public string Unit { get; set; }
        public DateTime? Cdate { get; set; }
        public bool? IsToStock { get; set; }
        public string StkEmpId { get; set; }
        public DateTime? StkDate { get; set; }

        public virtual ICollection<MtExtraD> MtExtraD { get; set; }
    }
}
