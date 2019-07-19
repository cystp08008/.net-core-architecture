using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class EngPicVer
    {
        public IEnumerable<PicVer> picVer { get; set; }
        public IEnumerable<EngPicWareH> engPic_WareH { get; set; }
    }
}