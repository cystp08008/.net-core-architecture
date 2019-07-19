using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class MaterialSet
    {
        public IEnumerable<Material> material { get; set; }
        public IEnumerable<MaterialEng> material_Eng { get; set; }
    }
}