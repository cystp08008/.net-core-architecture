using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Eng
    {
        public Eng()
        {
            EngRight = new HashSet<EngRight>();
            EngTier = new HashSet<EngTier>();
            Making = new HashSet<Making>();
        }

        public string CengId { get; set; }
        public string CengName { get; set; }
        public string CengClass { get; set; }
        public float BengGround { get; set; }
        public float BbldgGround { get; set; }
        public float BbldgArea { get; set; }
        public string CPicPath { get; set; }
        public float BengWeight { get; set; }
        public string CcontraId { get; set; }
        public string CkgId { get; set; }
        public bool LbomO { get; set; }
        public bool LbomFb { get; set; }
        public bool LmctO { get; set; }
        public bool LmctFb { get; set; }
        public string CpaintId { get; set; }
        public string CengSna { get; set; }
        public string CflowId { get; set; }
        public string Cowner { get; set; }
        public DateTime? DstartDate { get; set; }
        public DateTime? DcompDate { get; set; }
        public float? BagrmPrice { get; set; }
        public DateTime? Dclose { get; set; }
        public string CpaintFb { get; set; }
        public DateTime? Dgetdeal { get; set; }
        public string CpaintSp { get; set; }
        public string CSort { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CpaintDph { get; set; }
        public string CengQaname { get; set; }
        public string CownerId { get; set; }
        public string CbuildId { get; set; }
        public string CadviserId { get; set; }
        public string CdirectId { get; set; }
        public string ExamEngName { get; set; }

        public virtual CmdClass CengClassNavigation { get; set; }
        public virtual ICollection<EngRight> EngRight { get; set; }
        public virtual ICollection<EngTier> EngTier { get; set; }
        public virtual ICollection<Making> Making { get; set; }
    }
}
