using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class EngRight
    {
        public string CengId { get; set; }
        public string CId { get; set; }
        public DateTime Cdate { get; set; }

        public virtual Comsup C { get; set; }
        public virtual Eng Ceng { get; set; }
    }
}
