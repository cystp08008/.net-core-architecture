using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrTitle
    {
        public NcrTitle()
        {
            NcrBom = new HashSet<NcrBom>();
            NcrDuty = new HashSet<NcrDuty>();
            NcrFault = new HashSet<NcrFault>();
            NcrFeedBack = new HashSet<NcrFeedBack>();
            NcrImprov = new HashSet<NcrImprov>();
            NcrIssueUnit = new HashSet<NcrIssueUnit>();
            NcrProposal = new HashSet<NcrProposal>();
            NcrStatus = new HashSet<NcrStatus>();
            NcrStrategy = new HashSet<NcrStrategy>();
            NcrType = new HashSet<NcrType>();
        }

        public string CengId { get; set; }
        public string RepId { get; set; }
        public bool Isfactory { get; set; }
        public decimal NworkH { get; set; }
        public DateTime? Deadline { get; set; }
        public bool Lappendix { get; set; }
        public string CDepId { get; set; }
        public string CusrName { get; set; }
        public string Cdescp { get; set; }
        public string Cproposal { get; set; }
        public string Creatname { get; set; }
        public DateTime Cdate { get; set; }
        public DateTime? Dfinish { get; set; }
        public bool? Lstrategy { get; set; }
        public DateTime? Distdate { get; set; }
        public string ClsNo { get; set; }
        public decimal? NactworkH { get; set; }
        public string Creplen { get; set; }
        public int? IflowId { get; set; }
        public bool Lprop { get; set; }
        public bool Lresp { get; set; }
        public bool Lissue { get; set; }
        public DateTime SaveDate { get; set; }
        public DateTime ChkDate { get; set; }
        public bool? LDelayClose { get; set; }
        public string DelayNote { get; set; }
        public int? IErrType { get; set; }
        public string Canceldesp { get; set; }

        public virtual ICollection<NcrBom> NcrBom { get; set; }
        public virtual ICollection<NcrDuty> NcrDuty { get; set; }
        public virtual ICollection<NcrFault> NcrFault { get; set; }
        public virtual ICollection<NcrFeedBack> NcrFeedBack { get; set; }
        public virtual ICollection<NcrImprov> NcrImprov { get; set; }
        public virtual ICollection<NcrIssueUnit> NcrIssueUnit { get; set; }
        public virtual ICollection<NcrProposal> NcrProposal { get; set; }
        public virtual ICollection<NcrStatus> NcrStatus { get; set; }
        public virtual ICollection<NcrStrategy> NcrStrategy { get; set; }
        public virtual ICollection<NcrType> NcrType { get; set; }
    }
}
