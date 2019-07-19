using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtReturnT
    {
        public MtReturnT()
        {
            MtReturnD = new HashSet<MtReturnD>();
        }

        public string WhnoI { get; set; }
        public string RepId { get; set; }
        public string ActNo { get; set; }
        public DateTime Rdate { get; set; }
        public string Unit { get; set; }
        public string ComMf { get; set; }
        public bool? IsToStock { get; set; }
        public string StkEmpId { get; set; }
        public DateTime? StkDate { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual ICollection<MtReturnD> MtReturnD { get; set; }
    }
}
