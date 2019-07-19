using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TRptMemUseQry
    {
        public long Pk { get; set; }
        public int Num { get; set; }
        public string CengId { get; set; }
        public string CengName { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CdivName { get; set; }
        public string CmdmPic { get; set; }
        public string CmemId { get; set; }
        public int? ImemQty { get; set; }
        public string CSpec { get; set; }
        public decimal? GrossWet { get; set; }
        public decimal? PicWet { get; set; }
        public decimal? MctWet { get; set; }
        public DateTime? Cdate { get; set; }
    }
}
