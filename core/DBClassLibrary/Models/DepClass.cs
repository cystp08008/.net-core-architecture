using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class DepClass
    {
        public DepClass()
        {
            DepUser = new HashSet<DepUser>();
        }

        public int IClass { get; set; }
        public string CName { get; set; }

        public virtual ICollection<DepUser> DepUser { get; set; }
    }
}
