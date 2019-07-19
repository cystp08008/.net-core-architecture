using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class MemClass
    {
        public IEnumerable<EngMemType> engMemtype { get; set; }
        public IEnumerable<MemType> NoneEngMemtype { get; set; }
    }
}