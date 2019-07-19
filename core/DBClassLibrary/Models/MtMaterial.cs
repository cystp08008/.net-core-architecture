using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtMaterial
    {
        public MtMaterial()
        {
            MtReturnD = new HashSet<MtReturnD>();
        }

        public string MtNo { get; set; }
        public string Spec { get; set; }
        public string CmaName { get; set; }
        public decimal? Wet { get; set; }
        public string WetUid { get; set; }
        public string MtType { get; set; }
        public string ComsupId { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string Cdescrip { get; set; }

        public virtual ICollection<MtReturnD> MtReturnD { get; set; }
    }
}
