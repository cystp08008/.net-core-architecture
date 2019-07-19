using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class PicVer
    {
        public string CengId { get; set; }
        public int VerNo { get; set; }
        public string VerName { get; set; }
        public string VerDesp { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string CusrName { get; set; }
    }
}
