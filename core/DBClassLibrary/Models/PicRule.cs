using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class PicRule
    {
        public string CPicClass { get; set; }
        public string CPicType { get; set; }
        public string CFixCode { get; set; }
        public int? IFixSite { get; set; }
        public string CDescp { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual PicClass CPicClassNavigation { get; set; }
        public virtual PicType CPicTypeNavigation { get; set; }
    }
}
