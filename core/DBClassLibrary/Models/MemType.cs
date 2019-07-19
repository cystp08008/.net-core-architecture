using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MemType
    {
        public string CbelongId { get; set; }
        public string CName { get; set; }
        public string CbelongName { get; set; }
        public byte Nsort { get; set; }
        public string CsubjectId { get; set; }
    }
}
