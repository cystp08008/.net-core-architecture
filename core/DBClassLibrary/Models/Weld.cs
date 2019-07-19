using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Weld
    {
        public string CweldId { get; set; }
        public string CweldClass { get; set; }
        public string CweldName { get; set; }
        public string LweldSite { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public Guid Rowguid { get; set; }
    }
}
