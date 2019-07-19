using System;
using System.Collections.Generic;

namespace DBClassLibrary.Models
{
    public partial class TImportComSup
    {
        public int WorsId { get; set; }
        public int Num { get; set; }
        public string CengId { get; set; }
        public string CmemId { get; set; }
        public string CdivName { get; set; }
        public string Csup0700Sna { get; set; }
        public string Cfied0700Sna { get; set; }
        public string Csup0800Sna { get; set; }
        public string Cfied0800Sna { get; set; }
        public string Csup1000Sna { get; set; }
        public string Cfied1000Sna { get; set; }
        public DateTime? DRender { get; set; }
        public string CpaintSna { get; set; }
    }
}
