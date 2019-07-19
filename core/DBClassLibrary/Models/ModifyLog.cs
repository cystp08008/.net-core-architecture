using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class ModifyLog
    {
        public long IOrder { get; set; }
        public string CTableName { get; set; }
        public string CMode { get; set; }
        public string CengId { get; set; }
        public string CPk { get; set; }
        public string CFieldName { get; set; }
        public string COldValue { get; set; }
        public string CNewValue { get; set; }
        public DateTime? Cdate { get; set; }
        public string CusrName { get; set; }
    }
}
