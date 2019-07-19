using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class EngTier
    {
        public EngTier()
        {
            Member = new HashSet<Member>();
        }

        public string CengId { get; set; }
        public string CtierName { get; set; }
        public string Descrip { get; set; }

        public virtual Eng Ceng { get; set; }
        public virtual ICollection<Member> Member { get; set; }
    }
}
