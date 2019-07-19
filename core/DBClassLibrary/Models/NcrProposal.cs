using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrProposal
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CDepId { get; set; }
        public string Cproposal { get; set; }

        public virtual NcrTitle NcrTitle { get; set; }
    }
}
