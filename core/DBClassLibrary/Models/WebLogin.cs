using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class WebLogin
    {
        public long Pk { get; set; }
        public string CusrName { get; set; }
        public string Cname { get; set; }
        public bool? Issuccess { get; set; }
        public DateTime? Cdate { get; set; }
        public string IpAddress { get; set; }
    }
}
