using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class Comsup
    {
        public Comsup()
        {
            ComsupWork = new HashSet<ComsupWork>();
            EngRight = new HashSet<EngRight>();
            FbForm = new HashSet<FbForm>();
            MemComsup = new HashSet<MemComsup>();
            Tuser = new HashSet<Tuser>();
        }

        public string CsupId { get; set; }
        public string CsupName { get; set; }
        public string CsupSna { get; set; }
        public string CsupDesp { get; set; }
        public string Caddress { get; set; }
        public string CLeader { get; set; }
        public string Cfax { get; set; }
        public string Ctel1 { get; set; }
        public string Ctel2 { get; set; }
        public string CsupNum { get; set; }
        public int? CsupType { get; set; }
        public string CaddressF { get; set; }

        public virtual ICollection<ComsupWork> ComsupWork { get; set; }
        public virtual ICollection<EngRight> EngRight { get; set; }
        public virtual ICollection<FbForm> FbForm { get; set; }
        public virtual ICollection<MemComsup> MemComsup { get; set; }
        public virtual ICollection<Tuser> Tuser { get; set; }
    }
}
