using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DBClassLibrary.Models.ViewModel
{
    public class CreateEngCol
    {
        public IEnumerable<Kg> kg { get; set; }
        public IEnumerable<Contract> contract { get; set; }
        public IEnumerable<Flow> flow { get; set; }
        public IEnumerable<Eng> eng { get; set; }


        [DisplayName("工地代號")]
        [Required(ErrorMessage="不可為空")]
        [StringLength(7,ErrorMessage="最大長度為7字元")]
        public string ceng_id { get; set; }
        [DisplayName("工地簡稱")]
        [Required(ErrorMessage = "不可為空")]
        [StringLength(12, ErrorMessage = "最大長度為12字元")]
        public string ceng_sna { get; set; }


        [DisplayName("BOM表雜項是否計重")]
        public bool lbom_o { get; set; }
        [DisplayName("BOM表扁鋼是否計重")]
        public bool lbom_fb { get; set; }
        [DisplayName("構件管制表雜項是否計重")]
        public bool lmct_o { get; set; }
        [DisplayName("構件管制表扁鋼是否計重")]
        public bool lmct_fb { get; set; }
    }
}