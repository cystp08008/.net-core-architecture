using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class FbRepdTitle
    {
        public FbRepdTitle()
        {
            FbRepdDetail = new HashSet<FbRepdDetail>();
        }

        public string RepId { get; set; }
        public string CengId { get; set; }
        public string Descp { get; set; }
        public int Ftype { get; set; }
        public DateTime Cdate { get; set; }
        public string CusrName { get; set; }

        public virtual ICollection<FbRepdDetail> FbRepdDetail { get; set; }
    }
}
