using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class RGrpUserSup
    {
        public string CgrpName { get; set; }
        public string CId { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual Tgroup CgrpNameNavigation { get; set; }
    }
}
