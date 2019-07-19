using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Member
    {
        public Member()
        {
            Bom = new HashSet<Bom>();
            MemComsup = new HashSet<MemComsup>();
            MemDiv = new HashSet<MemDiv>();
        }

        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CmemPic { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public int ImemQty { get; set; }
        public string CpaintId { get; set; }
        public string CflowId { get; set; }
        public DateTime? Dtemplate { get; set; }
        public DateTime? Dtruler { get; set; }
        public DateTime? Dtrawin { get; set; }
        public DateTime? Dtlayout { get; set; }
        public DateTime? Dtbhin { get; set; }
        public float BmcutW { get; set; }
        public float BmcutA1 { get; set; }
        public float BmcutA2 { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public bool Lbom { get; set; }
        public string CusrName { get; set; }
        public string CmainId { get; set; }
        public string CljoinId { get; set; }
        public string CrjoinId { get; set; }
        public bool Lplant { get; set; }
        public DateTime? SpProd { get; set; }
        public DateTime? SpDraw { get; set; }
        public DateTime? SpSite { get; set; }
        public DateTime? SpData { get; set; }
        public DateTime? DBomNew { get; set; }
        public DateTime? DBomUpd { get; set; }
        public string DssNote { get; set; }
        public string PcsNote { get; set; }
        public string QasNote { get; set; }
        public string StsNote { get; set; }

        public virtual EngMemType C { get; set; }
        public virtual EngTier C1 { get; set; }
        public virtual EngPic CNavigation { get; set; }
        public virtual Member2 Member2 { get; set; }
        public virtual MemberFlag MemberFlag { get; set; }
        public virtual ICollection<Bom> Bom { get; set; }
        public virtual ICollection<MemComsup> MemComsup { get; set; }
        public virtual ICollection<MemDiv> MemDiv { get; set; }
    }
}
