using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class PilotSpDetail
    {
        public string RepId { get; set; }
        public string CengId { get; set; }
        public string CmakId { get; set; }
        public int Qty { get; set; }
        public string CmakDesp { get; set; }
        public float Bweight { get; set; }

        public virtual PilotSpTitle PilotSpTitle { get; set; }
    }
}
