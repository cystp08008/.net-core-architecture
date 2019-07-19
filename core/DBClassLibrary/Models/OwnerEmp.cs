using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class OwnerEmp
    {
        public OwnerEmp()
        {
            EngOwner = new HashSet<EngOwner>();
            QaRece = new HashSet<QaRece>();
        }

        public string COwnerId { get; set; }
        public string Contact { get; set; }
        public string CExt { get; set; }
        public string CTel { get; set; }
        public string CFax { get; set; }
        public string CEmail { get; set; }
        public string CNote { get; set; }

        public virtual Owner COwner { get; set; }
        public virtual ICollection<EngOwner> EngOwner { get; set; }
        public virtual ICollection<QaRece> QaRece { get; set; }
    }
}
