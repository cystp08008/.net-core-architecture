using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core.Models;
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

namespace core.Controllers
{
    public class HomeController : Controller
    {
        private readonly Bom2013Context Bom2013Context;
        private readonly IV_BomTxtRepository v_BomTxtRepository;
        private readonly IRepository<Making> makingRepository;
        private readonly IHomeService homeService;
        public HomeController(

            Bom2013Context Bom2013Context,
            IV_BomTxtRepository v_BomTxtRepository,
            IRepository<Making> makingRepository,
            IHomeService homeService
            )
        {


            this.Bom2013Context = Bom2013Context;
            this.v_BomTxtRepository = v_BomTxtRepository;
            this.makingRepository = makingRepository;
            this.homeService = homeService;

        }
        [AuthenticatedFilter]
        public IActionResult Home()
        {
            //var a = this.Bom2013Context.Eng;
            //var blogs = this.Bom2013Context.Database.ExecuteSqlCommand("[dbo].[GetFormData]");
            ////ViewData["a"] = blogs;
            ////var fd = this.engRepository.Get();
            //var k = this.v_BomTxtRepository.GetV_BomTxt();
            
            return View();
        }


        [AuthenticatedFilter]
        public IActionResult GetMain()
        {
            var main = this.homeService.GetMain();
            var user = HttpContext.Session.GetObject<Tuser>("user");
            var result = new { main = main, user = user };

            return Json(result);
        }


        [AuthenticatedFilter]
        public ActionResult GetMenu(string clickMenu)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");
            //
            var title = this.homeService.GetMainMenu(user.CusrName, clickMenu);


            return Json(title);


        }
      
        //以側邊導覽列 主項目 查詢子項目
        [AuthenticatedFilter]
        public ActionResult GetSubMenu(string Menu)
        {

            var user = HttpContext.Session.GetObject<Tuser>("user");


            var subMenu = this.homeService.GetSubMenu(user.CusrName, Menu);
         
            return Json(subMenu);


        }

        [AuthenticatedFilter]
        public ActionResult SetPwd(string pwd)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");


            this.homeService.UpdatePwd(user,pwd);


            return RedirectToAction("Home", "Home");

        }


        [AuthenticatedFilter]
        public ActionResult SetEng(string checkEng)
        {


            var eng = this.homeService.IsEng(checkEng);

            HttpContext.Session.SetObject("eng",eng);


            return Json(eng);
        }

        //紀錄 使用者 使用功能
        [AuthenticatedFilter]
        public ActionResult SetCfrm_name(string cfrm_name)
        {
            var user = HttpContext.Session.GetObject<Tuser>("user");

            this.homeService.CreateUserBehaviorLog( cfrm_name,user.CusrName);

            return Json("");
        }















    }
}
