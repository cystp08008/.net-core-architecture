using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class CutDistDetail
    {
        public string CengId { get; set; }
        public string RepId { get; set; }
        public int ItemNo { get; set; }
        public int ShapNo { get; set; }
        public string CdivName { get; set; }
        public string CmemId { get; set; }
        public string CmakId { get; set; }
        public int Qty { get; set; }

        public virtual CutDistBom CutDistBom { get; set; }
        public virtual CutDistShape CutDistShape { get; set; }
        public virtual CutDistTitle CutDistTitle { get; set; }
    }
}
