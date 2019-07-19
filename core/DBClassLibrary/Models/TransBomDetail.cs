using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TransBomDetail
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CmemPic { get; set; }
        public string VerName { get; set; }

        public virtual TransBomTitle TransBomTitle { get; set; }
    }
}
