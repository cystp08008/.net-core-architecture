using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class UsageSet
    {
        public IEnumerable<Usage> usage { get; set; }
        public IEnumerable<Usage> usage_Eng { get; set; }
    }
}