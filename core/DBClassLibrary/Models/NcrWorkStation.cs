using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class NcrWorkStation
    {
        public NcrWorkStation()
        {
            NcrFeedBack = new HashSet<NcrFeedBack>();
        }

        public int IWorkStation { get; set; }
        public string CName { get; set; }
        public bool? IsFactory { get; set; }

        public virtual ICollection<NcrFeedBack> NcrFeedBack { get; set; }
    }
}
