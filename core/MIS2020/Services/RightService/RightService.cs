using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public class RightService : IRightService
    {
        #region Fields
        private readonly IRightRepository rightRepository;
        #endregion

        #region Ctor
        public RightService
        (
            IRightRepository rightRepository
        )
        {
            this.rightRepository = rightRepository;
        }
        #endregion

        #region Utilities



        /// <summary>
        /// Get 側邊導覽列 主項目 AA AB ... (依權限)
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="main">主項目(A資料維護)</param>
        /// <returns>側邊導覽列主項目</returns>
        public IQueryable<FormMain> GetMainMenu(string cusrName, string main)
        {
            return this.rightRepository.GetFormMainByRight(cusrName, main);
        }

        /// <summary>
        /// Get 側邊導覽列 子項目 AA01 AB01 ...(依權限)
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="mainMenu">子項目(AA01工令單)</param>
        /// <returns>側邊導覽列主項目</returns>
        public IQueryable<FormSub> GetSubMenu(string cusrName, string mainMenu)
        {
            return this.rightRepository.GetFormSubByRight(cusrName, mainMenu);
        }




        #endregion
    }
}
