using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class UserEngRight
    {
        public string CusrName { get; set; }
        public string CengId { get; set; }
        public bool? IsMaster { get; set; }
        public DateTime Cdate { get; set; }

        public virtual Tuser CusrNameNavigation { get; set; }
    }
}
