using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtRejT
    {
        public MtRejT()
        {
            MtRejD = new HashSet<MtRejD>();
        }

        public string RepId { get; set; }
        public string ActNo { get; set; }
        public string RepIdRecv { get; set; }
        public DateTime? Cdate { get; set; }
        public string ChkEmpId { get; set; }
        public bool? IsToStock { get; set; }
        public string StkEmpId { get; set; }
        public DateTime? StkDate { get; set; }

        public virtual ICollection<MtRejD> MtRejD { get; set; }
    }
}
