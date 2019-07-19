using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class AbnTitle
    {
        public AbnTitle()
        {
            AbnData = new HashSet<AbnData>();
        }

        public string CengId { get; set; }
        public string RepId { get; set; }
        public string Descp { get; set; }
        public string CusrName { get; set; }
        public DateTime? Cdate { get; set; }
        public string DefF1 { get; set; }
        public string DefF2 { get; set; }
        public string DefF3 { get; set; }
        public string DefF4 { get; set; }
        public string DefF5 { get; set; }
        public string DefF6 { get; set; }
        public string DefF7 { get; set; }
        public string DefF8 { get; set; }

        public virtual ICollection<AbnData> AbnData { get; set; }
    }
}
