using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class FieldWork
    {
        public string CfiedId { get; set; }
        public string CworkId { get; set; }
        public DateTime? Cdate { get; set; }

        public virtual Field Cfied { get; set; }
        public virtual Work Cwork { get; set; }
    }
}
