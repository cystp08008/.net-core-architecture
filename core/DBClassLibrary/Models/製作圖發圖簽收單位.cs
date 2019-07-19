using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class 製作圖發圖簽收單位
    {
        public 製作圖發圖簽收單位()
        {
            製作圖發圖簽收明細 = new HashSet<製作圖發圖簽收明細>();
        }

        public string 工程代號 { get; set; }
        public string 簽收單號 { get; set; }
        public string 發送單位 { get; set; }
        public int? 份數a3 { get; set; }
        public int? 份數a2 { get; set; }
        public DateTime? 建立日期 { get; set; }
        public string 備註 { get; set; }
        public bool? 資料審核 { get; set; }

        public virtual 製作圖發圖總表Title 製作圖發圖總表Title { get; set; }
        public virtual ICollection<製作圖發圖簽收明細> 製作圖發圖簽收明細 { get; set; }
    }
}
