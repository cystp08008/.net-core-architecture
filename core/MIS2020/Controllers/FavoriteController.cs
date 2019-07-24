using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Services;
using core.SessionExtensions;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Mvc;

namespace core.Controllers
{
    public class FavoriteController : Controller
    {
        #region Fields
        private readonly IFavoriteService favoriteService;
        #endregion

        #region Ctor
        public FavoriteController(IFavoriteService favoriteService)
        {
            this.favoriteService = favoriteService;
        }
        #endregion

        #region ViewAction
        public IActionResult Favorite()
        {
            return View();
        }
        #endregion


        #region Methods

        //Get 使用者快速連結
        public JsonResult GetFavorite()
        {

            var user = HttpContext.Session.GetObject<Tuser>("user");

            var userFavorite= this.favoriteService.GetUserFavorite(user.CusrName);

            return Json(userFavorite);
        }
        //新增快速連結
        public JsonResult CreateFavorite(string favorite)
        {

            var user = HttpContext.Session.GetObject<Tuser>("user");

            this.favoriteService.CreateFavorite(user.CusrName,favorite);


            return new NullJsonResult();
        }


        //移除快速連結
        public JsonResult DeleteFavorite(string favorite)
        {

            var user = HttpContext.Session.GetObject<Tuser>("user");

            this.favoriteService.DeleteFavorite(user.CusrName, favorite);

            return new NullJsonResult();
        }

        #endregion
    }
}