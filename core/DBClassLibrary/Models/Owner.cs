using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Owner
    {
        public Owner()
        {
            OwnerEmp = new HashSet<OwnerEmp>();
        }

        public string COwnerId { get; set; }
        public string CName { get; set; }
        public string CAddress { get; set; }
        public string CTel { get; set; }
        public string CFax { get; set; }

        public virtual ICollection<OwnerEmp> OwnerEmp { get; set; }
    }
}
