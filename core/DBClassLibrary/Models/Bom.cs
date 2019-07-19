using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Bom
    {
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CmakId { get; set; }
        public int IbomQty { get; set; }
        public int IOrder { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string CusrName { get; set; }

        public virtual Making C { get; set; }
        public virtual Member CNavigation { get; set; }
    }
}
