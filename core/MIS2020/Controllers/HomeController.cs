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
using AuthorizationCenter.Filters;
using core.Services;
using Nop.Web.Framework.Mvc;

namespace core.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        private readonly IEngService engService;
        private readonly ITuserService tuserService;
        private readonly IRightService rightService;
        private readonly IFormGroupService formGroupService;
        private readonly IUserBehaviorLogService userBehaviorLogService;


        #endregion

        #region Ctor
        public HomeController(

            IEngService engService,
            ITuserService tuserService,
            IRightService rightService,
            IFormGroupService formGroupService,
            IUserBehaviorLogService userBehaviorLogService

            )
        {

            this.tuserService = tuserService;
            this.engService = engService;
            this.rightService = rightService;
            this.formGroupService = formGroupService;
            this.userBehaviorLogService = userBehaviorLogService;


        }
        #endregion


        #region ViewAction
   
        public IActionResult Index()
        {
            return View();
        }
        #endregion


        #region Methods


        #region 導覽列顯示

        //Get 頂端導覽列 項目 A B C D

        public IActionResult GetMain()
        {
            var main = this.formGroupService.GetMain();
            var user = HttpContext.Session.GetObject<Tuser>("user");
            var result = new { main = main, user = user };

            return Json(result);
        }

        //Get 側邊導覽列 主項目AA AB

        public ActionResult GetMainMenu(string main)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");
            //
            var title = this.rightService.GetMainMenu(user.CusrName, main);


            return Json(title);


        }

        //Get 以側邊導覽列 子項目 AA01 AA02

        public ActionResult GetSubMenu(string Menu)
        {

            var user = HttpContext.Session.GetObject<Tuser>("user");


            var subMenu = this.rightService.GetSubMenu(user.CusrName, Menu);

            return Json(subMenu);


        }

        #endregion

        #region 使用者 變更密碼 欲選取工程 使用紀錄
        //Update 密碼

        public ActionResult UpdatePwd(string pwd)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");


            this.tuserService.UpdatePwd(user, pwd);


            return RedirectToAction("Home", "Home");

        }

        //判斷輸入工程 並建立Session

        public ActionResult SetEng(string checkEng)
        {


            var eng = this.engService.IsEng(checkEng);

            HttpContext.Session.SetObject("eng", eng);


            return Json(eng);
        }

        //紀錄 使用者 使用功能

        public ActionResult CreateUserBehaviorLog(string cfrmName)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");

            this.userBehaviorLogService.CreateUserBehaviorLog(cfrmName, user.CusrName);

            return new NullJsonResult();
        }

        #endregion

        #endregion

    }
}
