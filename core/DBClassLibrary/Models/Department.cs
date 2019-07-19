using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Department
    {
        public Department()
        {
            DepUser = new HashSet<DepUser>();
            FbForm = new HashSet<FbForm>();
        }

        public string CDepId { get; set; }
        public string CDepName { get; set; }
        public string CDepSna { get; set; }
        public int SendMailType { get; set; }

        public virtual ICollection<DepUser> DepUser { get; set; }
        public virtual ICollection<FbForm> FbForm { get; set; }
    }
}
