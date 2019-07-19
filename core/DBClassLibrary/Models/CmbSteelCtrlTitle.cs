using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class CmbSteelCtrlTitle
    {
        public CmbSteelCtrlTitle()
        {
            CmbSteelCtrlDetail = new HashSet<CmbSteelCtrlDetail>();
        }

        public string RepId { get; set; }
        public string CSite { get; set; }
        public string CengId { get; set; }
        public string CtierName { get; set; }
        public string CmaName { get; set; }
        public DateTime Cdate { get; set; }

        public virtual ICollection<CmbSteelCtrlDetail> CmbSteelCtrlDetail { get; set; }
    }
}
