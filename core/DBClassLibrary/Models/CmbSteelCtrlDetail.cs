using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class CmbSteelCtrlDetail
    {
        public string RepId { get; set; }
        public int IOrder { get; set; }
        public string CbelongId { get; set; }
        public string CclassId { get; set; }
        public decimal? Dim1 { get; set; }
        public decimal? Dim2 { get; set; }
        public decimal? Dim3 { get; set; }
        public decimal? Dim4 { get; set; }
        public decimal? NmakLen { get; set; }
        public string Cdescrip { get; set; }
        public string Cspec { get; set; }
        public int? Iqty { get; set; }
        public decimal? NWeight { get; set; }

        public virtual CmbSteelCtrlTitle Rep { get; set; }
    }
}
