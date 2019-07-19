using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class PicClass
    {
        public PicClass()
        {
            PicRule = new HashSet<PicRule>();
        }

        public string CPicClass { get; set; }
        public string CName { get; set; }
        public DateTime? Cdate { get; set; }
        public bool? LMember { get; set; }

        public virtual ICollection<PicRule> PicRule { get; set; }
    }
}
