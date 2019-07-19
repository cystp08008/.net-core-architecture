using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Qa
    {
        public Qa()
        {
            QaFeedback = new HashSet<QaFeedback>();
            QaRece = new HashSet<QaRece>();
            QaStatus = new HashSet<QaStatus>();
        }

        public string RepId { get; set; }
        public string CengId { get; set; }
        public DateTime Cdate { get; set; }
        public string CusrName { get; set; }
        public string CDepId { get; set; }
        public DateTime? DClose { get; set; }
        public int IwfId { get; set; }
        public int IflowId { get; set; }
        public string CTitle { get; set; }
        public string CRequest { get; set; }
        public DateTime? DExpAns { get; set; }
        public DateTime? DActAns { get; set; }
        public byte? IRating { get; set; }
        public bool? BImper { get; set; }
        public string CClose { get; set; }
        public string CCreatUser { get; set; }

        public virtual ICollection<QaFeedback> QaFeedback { get; set; }
        public virtual ICollection<QaRece> QaRece { get; set; }
        public virtual ICollection<QaStatus> QaStatus { get; set; }
    }
}
