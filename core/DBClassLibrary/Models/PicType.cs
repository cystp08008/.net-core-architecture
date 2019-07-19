using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class PicType
    {
        public PicType()
        {
            PicRule = new HashSet<PicRule>();
        }

        public string CPicType { get; set; }
        public string CName { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual ICollection<PicRule> PicRule { get; set; }
    }
}
