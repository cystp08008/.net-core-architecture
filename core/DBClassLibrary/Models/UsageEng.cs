using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class UsageEng
    {
        public string CuseId { get; set; }
        public string CengId { get; set; }
        public string CpaintId { get; set; }

        public virtual Usage Cuse { get; set; }
    }
}
