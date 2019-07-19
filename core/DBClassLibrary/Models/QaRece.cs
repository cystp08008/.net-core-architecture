using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class QaRece
    {
        public string RepId { get; set; }
        public string CownerId { get; set; }
        public string Contact { get; set; }
        public string COrig { get; set; }

        public virtual OwnerEmp Co { get; set; }
        public virtual Qa Rep { get; set; }
    }
}
