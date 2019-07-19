using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MtEng
    {
        public MtEng()
        {
            MtStockD = new HashSet<MtStockD>();
        }

        public string Wheng { get; set; }
        public string WhengName { get; set; }
        public string CSort { get; set; }
        public bool? MtClose { get; set; }

        public virtual ICollection<MtStockD> MtStockD { get; set; }
    }
}
