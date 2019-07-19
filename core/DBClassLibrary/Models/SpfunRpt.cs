using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class SpfunRpt
    {
        public string CengId { get; set; }
        public string CfunId { get; set; }
        public string CmakId { get; set; }
        public int? Iqty { get; set; }
        public int PlantQty { get; set; }
        public int ActuallyQty { get; set; }
        public long FunRptId { get; set; }

        public virtual SpfunTitle C { get; set; }
        public virtual SpFunSta FunRpt { get; set; }
    }
}
