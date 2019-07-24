using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public partial interface IRightService
    {


        /// <summary>
        /// Get 側邊導覽列 主項目 AA AB ... (依權限)
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="main">主項目(A資料維護)</param>
        /// <returns>側邊導覽列主項目</returns>
        IQueryable<FormMain> GetMainMenu(string cusrName, string main);

        /// <summary>
        /// Get 側邊導覽列 子項目 AA01 AB01 ...(依權限)
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="mainMenu">子項目(AA01工令單)</param>
        /// <returns>側邊導覽列主項目</returns>
        IQueryable<FormSub> GetSubMenu(string cusrName, string mainMenu);

    }
}
