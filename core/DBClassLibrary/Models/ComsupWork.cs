using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class ComsupWork
    {
        public string CsupId { get; set; }
        public string CworkId { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual Comsup Csup { get; set; }
        public virtual Work Cwork { get; set; }
    }
}
