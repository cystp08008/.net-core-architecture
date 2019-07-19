using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Right
    {
        public Right()
        {
            FormRight = new HashSet<FormRight>();
        }

        public string CRight { get; set; }
        public string CRightDesc { get; set; }
        public DateTime? Cdate { get; set; }
        public int IOrder { get; set; }

        public virtual ICollection<FormRight> FormRight { get; set; }
    }
}
