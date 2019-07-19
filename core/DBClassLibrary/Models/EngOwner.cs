using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class EngOwner
    {
        public string CengId { get; set; }
        public string COwnerId { get; set; }
        public string Contact { get; set; }
        public string CNote { get; set; }

        public virtual OwnerEmp C { get; set; }
    }
}
