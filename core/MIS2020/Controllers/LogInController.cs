using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.CYSTP.Libs.Security.dotnet;
using core.Services.CYSTP.Libs.Security.dotnet;
using core.Services.LogIn;
using core.SessionExtensions;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    public class LogInController : Controller
    {
        #region Fields
        private readonly ILogInService logInService;
        #endregion

        #region Ctor
        public LogInController(ILogInService logInService)
        {

            this.logInService = logInService;
        }
        #endregion

        #region ViewAction
        public IActionResult LogIn()
        {
            return View();
        }
        #endregion

        #region Methods

        [HttpPost]
        public IActionResult LogIn(Tuser tuser)
        {

            var IpAddress = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress.ToString();
            var logInUser = this.logInService.GetTuser(tuser.CusrName);

            //驗證密碼 加密後 是否與 資料庫加密 密碼 符合
            if (!this.logInService.ValidatePassword(logInUser, tuser.CusrPw))
            {
                ViewBag.Mess = "帳號密碼錯誤";

                this.logInService.CreateWebLogin(tuser.CusrPw, IpAddress);

                return View();
            }
            else
            {
                this.logInService.CreateWebLogin(logInUser, IpAddress);
         
                HttpContext.Session.SetObject("user", logInUser);

                return RedirectToAction("Home", "Home");
            }
                
        }

        #endregion


    }
}