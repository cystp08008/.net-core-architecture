using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class 製作圖發圖簽收明細
    {
        public string 工程代號 { get; set; }
        public string 簽收單號 { get; set; }
        public string 發送單位 { get; set; }
        public string 分區 { get; set; }
        public string 圖號 { get; set; }
        public DateTime? 建立日期 { get; set; }

        public virtual 製作圖發圖簽收單位 製作圖發圖簽收單位 { get; set; }
        public virtual 製作圖發圖總表圖號明細 製作圖發圖總表圖號明細 { get; set; }
    }
}
