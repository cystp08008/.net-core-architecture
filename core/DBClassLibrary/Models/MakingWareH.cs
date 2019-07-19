using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class MakingWareH
    {
        public string CengId { get; set; }
        public string CmakId { get; set; }
        public string VerName { get; set; }
        public string CmemPic { get; set; }
        public string Cdescrip { get; set; }
        public string Cspec { get; set; }
        public string CmaName { get; set; }
        public decimal NmakLen { get; set; }
        public decimal Nweight { get; set; }
        public string CuseId { get; set; }
        public string CmakDesp { get; set; }
        public float Lcal1 { get; set; }
        public float Lcal2 { get; set; }
        public decimal NcutW { get; set; }
        public bool Lmodify { get; set; }
        public float BsurfaceA { get; set; }
        public float BsurfaceB { get; set; }
        public bool Ledit { get; set; }
        public float BcutA1 { get; set; }
        public float BcutA2 { get; set; }
        public string CpaintId { get; set; }
        public float? Bweight { get; set; }
        public decimal NmakWidth { get; set; }
        public string CmainId { get; set; }

        public virtual EngPicWareH EngPicWareH { get; set; }
    }
}
