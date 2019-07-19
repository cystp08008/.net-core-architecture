using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class 製作圖發圖總表圖號明細
    {
        public 製作圖發圖總表圖號明細()
        {
            製作圖發圖簽收明細 = new HashSet<製作圖發圖簽收明細>();
        }

        public string 工程代號 { get; set; }
        public string 簽收單號 { get; set; }
        public string 分區 { get; set; }
        public string 圖號 { get; set; }
        public string 版次 { get; set; }
        public int? 分類 { get; set; }
        public string 冷作場地 { get; set; }
        public string 冷作廠商 { get; set; }
        public string 電焊場地 { get; set; }
        public string 電焊廠商 { get; set; }
        public string 依據描述 { get; set; }
        public DateTime? 建立日期 { get; set; }

        public virtual 製作圖發圖總表Title 製作圖發圖總表Title { get; set; }
        public virtual ICollection<製作圖發圖簽收明細> 製作圖發圖簽收明細 { get; set; }
    }
}
