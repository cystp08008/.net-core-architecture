using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SpLedger
    {
        public string CengId { get; set; }
        public string CmakId { get; set; }
        public int PlantQty { get; set; }
        public int StFeedback { get; set; }
        public int ProdFeedback { get; set; }
        public int DrawQty { get; set; }
        public int ArrangeQty { get; set; }
        public int RenewQty { get; set; }
        public int TuneQty { get; set; }
    }
}
