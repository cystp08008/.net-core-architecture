using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TransBomTitle
    {
        public TransBomTitle()
        {
            TransBomDetail = new HashSet<TransBomDetail>();
        }

        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CsupId { get; set; }
        public string CusrName { get; set; }
        public DateTime? Cdate { get; set; }
        public bool? LTrans { get; set; }
        public string CusrTrans { get; set; }
        public DateTime? DTrans { get; set; }
        public string CreceiveName { get; set; }
        public string Csendtitle { get; set; }
        public string Cnote { get; set; }

        public virtual ICollection<TransBomDetail> TransBomDetail { get; set; }
    }
}
