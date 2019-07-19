using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TImportFb
    {
        public string Qrykey { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public int IOrder { get; set; }
        public int? ImemQty { get; set; }
        public string CdivName { get; set; }
        public string CworkId { get; set; }
    }
}
