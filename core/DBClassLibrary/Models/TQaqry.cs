using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TQaqry
    {
        public int Rnum { get; set; }
        public DateTime? Render { get; set; }
        public string CengSna { get; set; }
        public int Num { get; set; }
        public string CQaId { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? DExpAns { get; set; }
        public DateTime? DClose { get; set; }
        public string Body { get; set; }
        public bool? Imper { get; set; }
        public string Note { get; set; }
    }
}
