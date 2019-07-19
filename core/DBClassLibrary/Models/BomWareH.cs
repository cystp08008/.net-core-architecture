using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class BomWareH
    {
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CmakId { get; set; }
        public string VerName { get; set; }
        public int IbomQty { get; set; }
        public int? IOrder { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string CusrName { get; set; }

        public virtual MemberWareH MemberWareH { get; set; }
    }
}
