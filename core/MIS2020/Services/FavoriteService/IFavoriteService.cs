using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public partial interface IFavoriteService
    {

        /// <summary>
        /// GET 使用者快速連結
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <returns>使用者所有快速連結</returns>
        IQueryable<UserFavoriteList> GetUserFavorite(string cusrName);
        /// <summary>
        ///Insert 快速連結 
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="favorite">欲加入快速連結功能</param>
        void CreateFavorite(string cusrName,string favorite);

        /// <summary>
        /// Delete 快速連結 
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="favorite">欲加入快速連結功能</param>
        void DeleteFavorite(string cusrName, string favorite);

    }
}
