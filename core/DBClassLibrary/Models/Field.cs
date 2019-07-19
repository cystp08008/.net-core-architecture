using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Field
    {
        public Field()
        {
            FbForm = new HashSet<FbForm>();
            FieldWork = new HashSet<FieldWork>();
        }

        public string CfiedId { get; set; }
        public string CfiedName { get; set; }
        public string CfiedDesp { get; set; }
        public string CfiedSna { get; set; }
        public string CDefDep { get; set; }

        public virtual ICollection<FbForm> FbForm { get; set; }
        public virtual ICollection<FieldWork> FieldWork { get; set; }
    }
}
