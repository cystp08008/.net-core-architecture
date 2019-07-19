using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class FbFormHistory
    {
        public string CEngId { get; set; }
        public string CFormId { get; set; }
        public string CWorkId { get; set; }
        public string CUnitId { get; set; }
        public string CFiedId { get; set; }
        public DateTime FbDate { get; set; }
        public DateTime AtDate { get; set; }
        public string CSupId { get; set; }
        public string CUserName { get; set; }
        public Guid Rowguid { get; set; }
    }
}
