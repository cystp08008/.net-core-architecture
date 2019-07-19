using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class EngMemType
    {
        public EngMemType()
        {
            Member = new HashSet<Member>();
        }

        public string CengId { get; set; }
        public string CbelongId { get; set; }
        public string CEngBelongDesc { get; set; }
        public string CDescp { get; set; }
        public DateTime? Cdate { get; set; }
        public string CpaintId { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
