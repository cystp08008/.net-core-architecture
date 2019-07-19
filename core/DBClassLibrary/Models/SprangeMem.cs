using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SprangeMem
    {
        public string CengId { get; set; }
        public string CRangeId { get; set; }
        public string CmemId { get; set; }
        public string CdivName { get; set; }
        public string CmemPic { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }

        public virtual SprangeTitle C { get; set; }
    }
}
