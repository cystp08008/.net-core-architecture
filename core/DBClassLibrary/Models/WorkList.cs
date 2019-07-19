using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class WorkList
    {
        public long SerId { get; set; }
        public string CfrmName { get; set; }
        public string RepId { get; set; }
        public string CDepId { get; set; }
        public string CusrName { get; set; }
        public int IflowId { get; set; }
        public int? IflowExp { get; set; }
        public int? IflowSecd { get; set; }
        public string CusrExe { get; set; }
        public DateTime? Dexe { get; set; }
        public string CTitle { get; set; }
        public DateTime? Cdate { get; set; }
        public string CNote { get; set; }
        public string CengId { get; set; }

        public virtual Tuser CusrNameNavigation { get; set; }
    }
}
