using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Tuser
    {
        public Tuser()
        {
            DepUser = new HashSet<DepUser>();
            UserEngRight = new HashSet<UserEngRight>();
            WorkList = new HashSet<WorkList>();
        }

        public string CusrName { get; set; }
        public string Cname { get; set; }
        public string CusrDesp { get; set; }
        public string CusrPw { get; set; }
        public bool Lstop { get; set; }
        public int? IloginNo { get; set; }
        public string CEmail { get; set; }
        public int? Ichgpwd { get; set; }
        public DateTime DDeadline { get; set; }
        public DateTime? DLogin { get; set; }
        public string CusrId { get; set; }
        public bool? Locked { get; set; }
        public DateTime? LockedDate { get; set; }
        public string IpAddress { get; set; }
        public bool? Online { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnser { get; set; }
        public string CsupId { get; set; }

        public virtual Comsup Csup { get; set; }
        public virtual ICollection<DepUser> DepUser { get; set; }
        public virtual ICollection<UserEngRight> UserEngRight { get; set; }
        public virtual ICollection<WorkList> WorkList { get; set; }
    }
}
