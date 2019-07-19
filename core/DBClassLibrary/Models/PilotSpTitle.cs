using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class PilotSpTitle
    {
        public PilotSpTitle()
        {
            PilotSpDetail = new HashSet<PilotSpDetail>();
        }

        public string RepId { get; set; }
        public string CengId { get; set; }
        public string Descp { get; set; }
        public string CusrName { get; set; }
        public DateTime Cdate { get; set; }
        public DateTime? DRecv { get; set; }
        public DateTime? DFb { get; set; }
        public string CGrantUnit { get; set; }
        public string StrSch { get; set; }

        public virtual ICollection<PilotSpDetail> PilotSpDetail { get; set; }
    }
}
