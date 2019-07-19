using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SteelClass
    {
        public SteelClass()
        {
            Profile = new HashSet<Profile>();
        }

        public string CclassId { get; set; }
        public string CclassCname { get; set; }
        public string CName { get; set; }
        public byte NdimNum { get; set; }
        public string Cseries { get; set; }
        public byte NclassSort { get; set; }
        public string CPicPath { get; set; }
        public byte? NDisplay { get; set; }
        public string CMakCat { get; set; }

        public virtual ICollection<Profile> Profile { get; set; }
    }
}
