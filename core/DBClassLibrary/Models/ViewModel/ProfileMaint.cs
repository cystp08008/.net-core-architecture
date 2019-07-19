using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class ProfileMaint
    {
        
    }

    public class CalProfile
    {
        public string steel_id { get; set; }
        public double    cdim1 { get; set; }
        public double    cdim2 { get; set; }
        public double    cdim3 { get; set; }
        public double    cdim4 { get; set; }
        public double  barea { get; set; }
        public double  bweight { get; set; }
        public double  bsurface_a { get; set; }
        public double  bsurface_b { get; set; }
    }
         


    public class ProfileMaintTable
    {
        public string cclass_id { get; set; }
        public double  barea { get; set; }
        public double  bweight { get; set; }
        public string cdescrip { get; set; }
        public double  bsurface_a { get; set; }
        public double  bsurface_b { get; set; }







    }
}