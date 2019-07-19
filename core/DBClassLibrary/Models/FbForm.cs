using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class FbForm
    {
        public FbForm()
        {
            BackFlow = new HashSet<BackFlow>();
            BackFlow2 = new HashSet<BackFlow2>();
            MemBack = new HashSet<MemBack>();
            MemBack2 = new HashSet<MemBack2>();
        }

        public string CengId { get; set; }
        public string CformId { get; set; }
        public string CworkId { get; set; }
        public string CDepId { get; set; }
        public string CfiedId { get; set; }
        public DateTime FbDate { get; set; }
        public DateTime? Atdate { get; set; }
        public string CsupId { get; set; }
        public DateTime Cdate { get; set; }
        public bool? IsBf { get; set; }
        public string CNote { get; set; }

        public virtual Department CDep { get; set; }
        public virtual Field Cfied { get; set; }
        public virtual Comsup Csup { get; set; }
        public virtual Work Cwork { get; set; }
        public virtual ICollection<BackFlow> BackFlow { get; set; }
        public virtual ICollection<BackFlow2> BackFlow2 { get; set; }
        public virtual ICollection<MemBack> MemBack { get; set; }
        public virtual ICollection<MemBack2> MemBack2 { get; set; }
    }
}
