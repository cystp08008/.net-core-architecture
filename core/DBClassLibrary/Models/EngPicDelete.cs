using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class EngPicDelete
    {
        public string CengId { get; set; }
        public string CmemPic { get; set; }
        public string VerName { get; set; }
        public DateTime? DUpd { get; set; }
        public string CUserName { get; set; }
        public DateTime? Cdate { get; set; }
        public string CPicClass { get; set; }
        public string CPicType { get; set; }
        public DateTime? DVer { get; set; }
        public string CsupId { get; set; }
        public bool? Lcheck { get; set; }
        public DateTime? Dcheck { get; set; }
        public string DependPic { get; set; }
    }
}
