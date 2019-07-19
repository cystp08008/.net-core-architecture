using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class DepUser
    {
        public string CDepId { get; set; }
        public string CusrName { get; set; }
        public int IClass { get; set; }

        public virtual Department CDep { get; set; }
        public virtual Tuser CusrNameNavigation { get; set; }
        public virtual DepClass IClassNavigation { get; set; }
    }
}
