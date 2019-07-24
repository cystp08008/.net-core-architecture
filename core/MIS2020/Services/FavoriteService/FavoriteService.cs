using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;

namespace core.Services
{
    public class FavoriteService : IFavoriteService
    {
        #region Fields
        private readonly IFavoriteFormRepository favoriteFormRepository;
        #endregion

        #region Ctor
        public FavoriteService(IFavoriteFormRepository favoriteFormRepository)
        {
            this.favoriteFormRepository = favoriteFormRepository;
        }
        #endregion

        #region Utilities

        /// <summary>
        ///Insert 快速連結 
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="favorite">欲加入快速連結功能</param>
        public void CreateFavorite(string cusrName, string favorite)
        {
            var insertFavorite =this.favoriteFormRepository.GetFirst(m => m.CusrName == cusrName && m.CfrmgroupId == favorite);

            //判斷是否已加入快速連結
            if (insertFavorite == null)
            {
                FavoriteForm favoriteForm = new FavoriteForm();

                favoriteForm.CfrmgroupId = favorite;
                favoriteForm.Inum = '8';
                favoriteForm.CusrName = cusrName;

                this.favoriteFormRepository.Create(favoriteForm);
            }
        }
        /// <summary>
        /// Delete 快速連結 
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="favorite">欲加入快速連結功能</param>
        public void DeleteFavorite(string cusrName, string favorite)
        {
            var deleteFavorite = this.favoriteFormRepository.GetFirst(m => m.CusrName == cusrName && m.CfrmgroupId == favorite);

            //判斷是否已加入快速連結
            if (deleteFavorite != null)
                favoriteFormRepository.Delete(deleteFavorite);

        }
        /// <summary>
        /// GET 使用者快速連結
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <returns>使用者所有快速連結</returns>
        public IQueryable<UserFavoriteList> GetUserFavorite(string cusrName)
        {
            return this.favoriteFormRepository.GetUserAll(cusrName);
        }

        #endregion
    }
}
