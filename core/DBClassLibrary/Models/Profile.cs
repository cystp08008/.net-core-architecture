using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Profile
    {
        public Profile()
        {
            Making = new HashSet<Making>();
        }

        public string CclassId { get; set; }
        public string Cdim1 { get; set; }
        public string Cdim2 { get; set; }
        public string Cdim3 { get; set; }
        public string Cdim4 { get; set; }
        public float Barea { get; set; }
        public float Bweight { get; set; }
        public string Cdescrip { get; set; }
        public float BsurfaceA { get; set; }
        public float BsurfaceB { get; set; }
        public bool? Ledit { get; set; }

        public virtual SteelClass Cclass { get; set; }
        public virtual ICollection<Making> Making { get; set; }
    }
}
