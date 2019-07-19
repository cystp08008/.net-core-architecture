using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{

    public class MakingMaint
    {
        public IEnumerable<SteelClass> steelClass { get; set; }
        public IEnumerable<MaterialEng> material_eng { get; set; }
        public IEnumerable<Usage> usage_eng { get; set; }
        public IEnumerable<Main> main { get; set; }
        public string cmak_id { get; set; }

    }

    public class CalMaking
    {
        public string cMakCat { get; set; }
        public float nmakWidth { get; set; }
        public float bweight { get; set; }
        public float nmak_len { get; set; }
        public float bsurface_a { get; set; }
        public float bsurface_b { get; set; }
    }
    public class MakingTable
    {
        public string cmak_id { get; set; }
        public string cspec { get; set; }
        public float lcal1 { get; set; }
        public string cma_name { get; set; }
        public string cmain_id { get; set; }
        public Nullable<float> bweight { get; set; }
        public string cuse_id { get; set; }


        public string cdescrip_main { get; set; }
        public string cma_name_main { get; set; }

    }


}