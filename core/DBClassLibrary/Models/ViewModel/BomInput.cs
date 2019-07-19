using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DBClassLibrary.Models.ViewModel
{
    public class BomInput
    {
        public IEnumerable<PicClass> picClass { get; set; }
        public IEnumerable<EngTier>engTier  { get; set; }
        public IEnumerable<EngMemType> engMemType { get; set; }
    }

    public class MemberTable
    {
        public string cmem_id { get; set; }
        public string ctier_name { get; set; }
        public string cbelong_id { get; set; }
        public int imem_qty { get; set; }
        public string c_spec { get; set; }
        public decimal PicWet { get; set; }

    }

    public class BomMember
    {
        public string cmem_pic { get; set; }
        public string cmem_id { get; set; }
        public int imem_qty { get; set; }
        public string c_spec { get; set; }
        public decimal PicWet { get; set; }

    }

    public class BomTable
    {


        public int iOrder { get; set; }
        public string cmak_id { get; set; }
        public int ibom_qty { get; set; }
        public string cspec { get; set; }
        public decimal nweight { get; set; }

        public string cma_name { get; set; }
        public string cuse_id { get; set; }
    }
}