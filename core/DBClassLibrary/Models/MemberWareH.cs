using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MemberWareH
    {
        public MemberWareH()
        {
            BomWareH = new HashSet<BomWareH>();
        }

        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string VerName { get; set; }
        public string CmemPic { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public int? ImemQty { get; set; }
        public string CpaintId { get; set; }
        public string CflowId { get; set; }
        public bool? Lcheck { get; set; }
        public DateTime? ChkDate { get; set; }
        public float? BmcutW { get; set; }
        public float? BmcutA1 { get; set; }
        public float? BmcutA2 { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public bool? Lbom { get; set; }
        public string CusrName { get; set; }
        public string CmainId { get; set; }
        public bool? Lplant { get; set; }

        public virtual EngPicWareH EngPicWareH { get; set; }
        public virtual Member2WareH Member2WareH { get; set; }
        public virtual ICollection<BomWareH> BomWareH { get; set; }
    }
}
