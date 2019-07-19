using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SpfunTitle
    {
        public SpfunTitle()
        {
            SpfunRpt = new HashSet<SpfunRpt>();
        }

        public string CengId { get; set; }
        public string CfunId { get; set; }
        public string CRangeId { get; set; }
        public string Cdescp { get; set; }
        public string CSiteId { get; set; }
        public DateTime? DFb { get; set; }
        public DateTime? Cdate { get; set; }
        public string StrSch { get; set; }
        public string CGrantUnit { get; set; }

        public virtual SprangeTitle C { get; set; }
        public virtual ICollection<SpfunRpt> SpfunRpt { get; set; }
    }
}
