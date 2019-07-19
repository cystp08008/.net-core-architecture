using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Material
    {
        public Material()
        {
            MaterialEng = new HashSet<MaterialEng>();
        }

        public byte Nsort { get; set; }
        public string CmaName { get; set; }
        public string CmaSpec { get; set; }

        public virtual ICollection<MaterialEng> MaterialEng { get; set; }
    }
}
