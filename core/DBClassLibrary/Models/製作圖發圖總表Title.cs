using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class 製作圖發圖總表Title
    {
        public 製作圖發圖總表Title()
        {
            製作圖發圖簽收單位 = new HashSet<製作圖發圖簽收單位>();
            製作圖發圖總表圖號明細 = new HashSet<製作圖發圖總表圖號明細>();
        }

        public string 工程代號 { get; set; }
        public string 簽收單號 { get; set; }
        public string 發圖內容 { get; set; }
        public string 修改依據 { get; set; }
        public int? 發圖類別 { get; set; }
        public string 備料圖簽收單號 { get; set; }
        public string 設變單號 { get; set; }
        public string 異常單號 { get; set; }
        public string 建立人員 { get; set; }
        public DateTime? 建立日期 { get; set; }

        public virtual ICollection<製作圖發圖簽收單位> 製作圖發圖簽收單位 { get; set; }
        public virtual ICollection<製作圖發圖總表圖號明細> 製作圖發圖總表圖號明細 { get; set; }
    }
}
