using System;
using System.Collections.Generic;
using System.Text;

namespace DBClassLibrary.Models.ViewModel
{
    public class FormMain
    {
        public string cfrmgroup_id { get; set; }
        public string cNo { get; set; }
        public string cfrmgroup_name { get; set; }
        public Nullable<byte> iSort { get; set; }
    }
    public class FormSub
    {
        public string cfrm_name { get; set; }
        public string cfrm_desp { get; set; }
        public string cfrmNo { get; set; }
        public string cfrmgroup_id { get; set; }

    }
}
