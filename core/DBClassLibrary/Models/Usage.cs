using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Usage
    {
        public Usage()
        {
            UsageEng = new HashSet<UsageEng>();
        }

        public string CuseId { get; set; }
        public string CuseName { get; set; }
        public byte Nsort { get; set; }
        public string CpaintId { get; set; }
        public string CuseSna { get; set; }

        public virtual ICollection<UsageEng> UsageEng { get; set; }
    }
}
