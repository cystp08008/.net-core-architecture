using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Qaexp
    {
        public string RepId { get; set; }
        public int IType { get; set; }
        public string CTitle { get; set; }
        public string CRequest { get; set; }
        public DateTime? Cdate { get; set; }
        public string CusrName { get; set; }
        public DateTime? Udate { get; set; }

        public virtual QaexpType ITypeNavigation { get; set; }
    }
}
