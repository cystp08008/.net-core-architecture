using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class MainMaterial
    {
        public IEnumerable<SteelClass> steelClass { get; set; }
        public IEnumerable<MaterialEng> material_eng { get; set; }
    }
    public class MainTable
    {
        public string cmain_id { get; set; }
        public string cdescrip { get; set; }
        public string cma_name { get; set; }

    }

}