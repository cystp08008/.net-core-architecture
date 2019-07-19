using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TChkComsupWork
    {
        public int Num { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CdivName { get; set; }
        public string CworkId { get; set; }
        public string CflowId { get; set; }
        public int? ImemQty { get; set; }
        public decimal? UseQty { get; set; }
        public decimal? SurplusQty { get; set; }
        public bool? Ok { get; set; }
        public string Message { get; set; }
    }
}
