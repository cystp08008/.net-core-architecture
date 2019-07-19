using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SignFlow
    {
        public int IwfId { get; set; }
        public string CwfName { get; set; }
        public int IflowId { get; set; }
        public string CflowName { get; set; }
        public string CDepId { get; set; }
        public int Iclass { get; set; }
        public DateTime Cdate { get; set; }
        public string CStatusDesp { get; set; }
    }
}
