using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class CutDistBom
    {
        public CutDistBom()
        {
            CutDistDetail = new HashSet<CutDistDetail>();
        }

        public string CengId { get; set; }
        public string RepId { get; set; }
        public string CdivName { get; set; }
        public string CmemId { get; set; }
        public string CmakId { get; set; }
        public string CtierName { get; set; }
        public string CbelongId { get; set; }
        public string CmemPic { get; set; }
        public int Qty { get; set; }
        public string CmakDesp { get; set; }
        public string CSpec { get; set; }
        public decimal Nlen { get; set; }
        public string CmaName { get; set; }
        public string CuseId { get; set; }
        public decimal Bweight { get; set; }

        public virtual CutDistTitle CutDistTitle { get; set; }
        public virtual ICollection<CutDistDetail> CutDistDetail { get; set; }
    }
}
