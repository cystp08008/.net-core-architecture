using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Making
    {
        public Making()
        {
            Bom = new HashSet<Bom>();
        }

        public string CengId { get; set; }
        public string CmakId { get; set; }
        public string Cdescrip { get; set; }
        public string Cspec { get; set; }
        public string CmaName { get; set; }
        public decimal? NmakLen { get; set; }
        public decimal Nweight { get; set; }
        public string CuseId { get; set; }
        public bool? Lregular { get; set; }
        public bool? Lhole { get; set; }
        public bool? Lcut { get; set; }
        public bool? Lweld { get; set; }
        public bool? Lbend { get; set; }
        public string CmakDesp { get; set; }
        public float Lcal1 { get; set; }
        public float Lcal2 { get; set; }
        public decimal NcutW { get; set; }
        public bool? Ltemplate { get; set; }
        public bool? Lsketch { get; set; }
        public bool? Lnc { get; set; }
        public bool? Lmodify { get; set; }
        public float BsurfaceA { get; set; }
        public float BsurfaceB { get; set; }
        public bool Ledit { get; set; }
        public float BcutA1 { get; set; }
        public float BcutA2 { get; set; }
        public string CpaintId { get; set; }
        public bool? Linternal { get; set; }
        public string CmainId { get; set; }
        public float? Bweight { get; set; }
        public decimal? NmakWidth { get; set; }
        public bool? Lprint { get; set; }
        public string CusrName { get; set; }
        public string CSiteId { get; set; }
        public DateTime? Cdate { get; set; }
        public DateTime? Udate { get; set; }
        public string Lpic { get; set; }

        public virtual Profile CdescripNavigation { get; set; }
        public virtual Eng Ceng { get; set; }
        public virtual ICollection<Bom> Bom { get; set; }
    }
}
