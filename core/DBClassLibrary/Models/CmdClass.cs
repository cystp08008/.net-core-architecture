using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class CmdClass
    {
        public CmdClass()
        {
            Eng = new HashSet<Eng>();
        }

        public string CengClass { get; set; }
        public string CclassName { get; set; }
        public string CpaintId { get; set; }

        public virtual ICollection<Eng> Eng { get; set; }
    }
}
