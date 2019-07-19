using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MaterialEng
    {
        public string CmaName { get; set; }
        public string CengId { get; set; }

        public virtual Material CmaNameNavigation { get; set; }
    }
}
