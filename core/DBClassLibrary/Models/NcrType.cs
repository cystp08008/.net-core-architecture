using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrType
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public int Itype { get; set; }
        public int ImemQty { get; set; }

        public virtual NcrTypeName ItypeNavigation { get; set; }
        public virtual NcrTitle NcrTitle { get; set; }
    }
}
