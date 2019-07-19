using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrTypeName
    {
        public NcrTypeName()
        {
            NcrType = new HashSet<NcrType>();
        }

        public int Itype { get; set; }
        public string CName { get; set; }
        public bool? Lfb { get; set; }
        public bool? Lfault { get; set; }

        public virtual ICollection<NcrType> NcrType { get; set; }
    }
}
