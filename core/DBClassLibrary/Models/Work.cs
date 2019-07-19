using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Work
    {
        public Work()
        {
            ComsupWork = new HashSet<ComsupWork>();
            FbForm = new HashSet<FbForm>();
            FieldWork = new HashSet<FieldWork>();
        }

        public string CworkId { get; set; }
        public string CworkName { get; set; }
        public string CworkDesp { get; set; }
        public string CworkSna { get; set; }
        public string CFbChar { get; set; }

        public virtual ICollection<ComsupWork> ComsupWork { get; set; }
        public virtual ICollection<FbForm> FbForm { get; set; }
        public virtual ICollection<FieldWork> FieldWork { get; set; }
    }
}
