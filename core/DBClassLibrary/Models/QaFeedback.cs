using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class QaFeedback
    {
        public DateTime DUp { get; set; }
        public string RepId { get; set; }
        public DateTime DFeedback { get; set; }
        public string CFileName { get; set; }

        public virtual Qa Rep { get; set; }
    }
}
