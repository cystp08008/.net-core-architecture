using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class QaexpType
    {
        public QaexpType()
        {
            Qaexp = new HashSet<Qaexp>();
        }

        public int IType { get; set; }
        public string CDescp { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual ICollection<Qaexp> Qaexp { get; set; }
    }
}
