using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Tgroup
    {
        public Tgroup()
        {
            FormRight = new HashSet<FormRight>();
            RGrpUserSup = new HashSet<RGrpUserSup>();
        }

        public string CgrpName { get; set; }
        public string CgrpDesp { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual ICollection<FormRight> FormRight { get; set; }
        public virtual ICollection<RGrpUserSup> RGrpUserSup { get; set; }
    }
}
