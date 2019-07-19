using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtRecvT
    {
        public MtRecvT()
        {
            MtRecvD = new HashSet<MtRecvD>();
        }

        public string RepId { get; set; }
        public string Whno { get; set; }
        public string Wheng { get; set; }
        public string ActNo { get; set; }
        public string Unit { get; set; }
        public DateTime? RecDate { get; set; }
        public string CsupId { get; set; }
        public DateTime? Cdate { get; set; }
        public bool? IsToStock { get; set; }
        public string StkEmpId { get; set; }
        public DateTime? StkDate { get; set; }
        public string ComMf { get; set; }

        public virtual ICollection<MtRecvD> MtRecvD { get; set; }
    }
}
