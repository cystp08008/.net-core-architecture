using DBClassLibrary.Models;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{      
        /// <summary>
        ///Homeservice interface
        /// </summary>
    public partial interface IHomeService
    {



        /// <summary>
        /// Get 頁面頂端導覽列 A資料維護
        /// </summary>
        /// <returns>主項目 A B C D</returns>
        IQueryable<FormGroup> GetMain();
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
        /// <summary>
        ///Update 密碼
        /// </summary>
        /// <param name="tuser">使用者Object</param>
        /// <param name="pwd">欲修改密碼</param>
        void UpdatePwd(Tuser tuser, string pwd);
        /// <summary>
        /// Check 工程是否為正確名稱
        /// </summary>
        /// <param name="eng">工程代號</param>
        /// <returns>Session需儲存的工程</returns>
        string IsEng(string eng);
        /// <summary>
        /// Insert 使用者使用的功能
        /// </summary>
        /// <param name="cfrmName">功能代號</param>
        /// <param name="cusrName">使用者帳號</param>
        void CreateUserBehaviorLog(string cfrmName,string cusrName);
    }
}
