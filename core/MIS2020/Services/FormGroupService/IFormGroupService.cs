using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public partial interface IFormGroupService
    {

        /// <summary>
        /// Get 頁面頂端導覽列 A資料維護
        /// </summary>
        /// <returns>主項目 A B C D</returns>
        IQueryable<FormGroup> GetMain();
    }
}
