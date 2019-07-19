using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class FormGroup
    {
        public FormGroup()
        {
            Form = new HashSet<Form>();
        }

        public string CfrmgroupId { get; set; }
        public string CfrmgroupName { get; set; }
        public byte? ISort { get; set; }
        public string CParent { get; set; }
        public byte? ILevel { get; set; }
        public string CNo { get; set; }
        public string Cid { get; set; }
        public bool? Rpt { get; set; }

        public virtual ICollection<Form> Form { get; set; }
    }
}
