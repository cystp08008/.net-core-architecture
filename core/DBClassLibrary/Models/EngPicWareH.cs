using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class EngPicWareH
    {
        public EngPicWareH()
        {
            MakingWareH = new HashSet<MakingWareH>();
            MemberWareH = new HashSet<MemberWareH>();
        }

        public string CengId { get; set; }
        public string CmemPic { get; set; }
        public string VerName { get; set; }
        public DateTime? DUpd { get; set; }
        public string CUserName { get; set; }
        public DateTime? Cdate { get; set; }
        public string CPicClass { get; set; }
        public string CPicType { get; set; }
        public DateTime? DVer { get; set; }
        public string CVerUser { get; set; }

        public virtual ICollection<MakingWareH> MakingWareH { get; set; }
        public virtual ICollection<MemberWareH> MemberWareH { get; set; }
    }
}
