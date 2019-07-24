using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.Repository;
using Microsoft.AspNetCore.Http;
using core.SessionExtensions;
using DBClassLibrary.Models;
using core.CYSTP.Libs.Security.dotnet;
using AuthorizationCenter.Filters;
using core.Services;
using Nop.Web.Framework.Mvc;

namespace core.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        private readonly Bom2013Context Bom2013Context;
        private readonly IRepository<Making> makingRepository;
        private readonly IHomeService homeService;

        #endregion

        #region Ctor
        public HomeController(

            Bom2013Context Bom2013Context,
            IRepository<Making> makingRepository,
            IHomeService homeService

            )
        {


            this.Bom2013Context = Bom2013Context;
            this.makingRepository = makingRepository;
            this.homeService = homeService;

        }
        #endregion


        #region ViewAction
        [AuthenticatedFilter]
        public IActionResult Home()
        {


            return View();
        }
        #endregion


        #region Methods


        #region 導覽列顯示

        //Get 頂端導覽列 項目 A B C D
        [AuthenticatedFilter]
        public IActionResult GetMain()
        {
            var main = this.homeService.GetMain();
            var user = HttpContext.Session.GetObject<Tuser>("user");
            var result = new { main = main, user = user };

            return Json(result);
        }

        //Get 側邊導覽列 主項目AA AB
        [AuthenticatedFilter]
        public ActionResult GetMainMenu(string main)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");
            //
            var title = this.homeService.GetMainMenu(user.CusrName, main);


            return Json(title);


        }

        //Get 以側邊導覽列 子項目 AA01 AA02
        [AuthenticatedFilter]
        public ActionResult GetSubMenu(string Menu)
        {

            var user = HttpContext.Session.GetObject<Tuser>("user");


            var subMenu = this.homeService.GetSubMenu(user.CusrName, Menu);

            return Json(subMenu);


        }

        #endregion

        #region 使用者 變更密碼 欲選取工程 使用紀錄
        //Update 密碼
        [AuthenticatedFilter]
        public ActionResult UpdatePwd(string pwd)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");


            this.homeService.UpdatePwd(user, pwd);


            return RedirectToAction("Home", "Home");

        }

        //判斷輸入工程 並建立Session
        [AuthenticatedFilter]
        public ActionResult SetEng(string checkEng)
        {


            var eng = this.homeService.IsEng(checkEng);

            HttpContext.Session.SetObject("eng", eng);


            return Json(eng);
        }

        //紀錄 使用者 使用功能
        [AuthenticatedFilter]
        public ActionResult CreateUserBehaviorLog(string cfrmName)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");

            this.homeService.CreateUserBehaviorLog(cfrmName, user.CusrName);

            return new NullJsonResult();
        }

        #endregion

        #endregion













    }
}
