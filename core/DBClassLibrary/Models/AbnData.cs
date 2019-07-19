using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class AbnData
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CmemId { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CmemPic { get; set; }
        public int? ImemQty { get; set; }
        public bool? DefF1 { get; set; }
        public bool? DefF2 { get; set; }
        public bool? DefF3 { get; set; }
        public bool? DefF4 { get; set; }
        public bool? DefF5 { get; set; }
        public bool? DefF6 { get; set; }
        public bool? DefF7 { get; set; }
        public bool? DefF8 { get; set; }

        public virtual AbnTitle AbnTitle { get; set; }
    }
}
