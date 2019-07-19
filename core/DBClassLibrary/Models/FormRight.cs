using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class FormRight
    {
        public string CgrpName { get; set; }
        public string CfrmName { get; set; }
        public string CRight { get; set; }

        public virtual Right CRightNavigation { get; set; }
        public virtual Form CfrmNameNavigation { get; set; }
        public virtual Tgroup CgrpNameNavigation { get; set; }
    }
}
