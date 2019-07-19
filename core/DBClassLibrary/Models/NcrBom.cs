using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrBom
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CmemId { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CmemPic { get; set; }
        public int ImemQty { get; set; }

        public virtual NcrTitle NcrTitle { get; set; }
    }
}
