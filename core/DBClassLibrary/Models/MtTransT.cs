using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtTransT
    {
        public MtTransT()
        {
            MtTransD = new HashSet<MtTransD>();
        }

        public string RepId { get; set; }
        public string Whno { get; set; }
        public DateTime? TransDate { get; set; }
        public bool? IsToStock { get; set; }
        public string StkEmpId { get; set; }
        public DateTime? StkDate { get; set; }
        public DateTime? Cdate { get; set; }
        public string Unit { get; set; }

        public virtual ICollection<MtTransD> MtTransD { get; set; }
    }
}
