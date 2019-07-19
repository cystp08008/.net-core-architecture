using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class UserBehaviorLog
    {
        public string CfrmName { get; set; }
        public string CusrName { get; set; }
        public DateTime Cdate { get; set; }
        public long Pk { get; set; }
    }
}
