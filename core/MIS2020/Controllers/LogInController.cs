using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Services;
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
        private readonly ITuserService tuserService;
        private readonly IWebLoginService webLoginService;
        private readonly IPasswordEncryptService passwordEncryptService;
        #endregion

        #region Ctor
        public LogInController
        (
            ITuserService tuserService,
            IWebLoginService webLoginService,
            IPasswordEncryptService passwordEncryptService
        )
        {

            this.tuserService = tuserService;
            this.webLoginService = webLoginService;
            this.passwordEncryptService = passwordEncryptService;

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
            var logInUser = this.tuserService.GetTuser(tuser.CusrName);

            //驗證密碼 加密後 是否與 資料庫加密 密碼 符合
            if (!this.tuserService.ValidatePassword(logInUser, tuser.CusrPw))
            {
                ViewBag.Mess = "帳號密碼錯誤";

                this.webLoginService.CreateWebLogin(tuser.CusrPw, IpAddress);

                return View();
            }
            else
            {
                this.webLoginService.CreateWebLogin(logInUser, IpAddress);

                HttpContext.Session.SetObject("user", logInUser);

                //var userAccount = logInUser.CusrName;
                //var userName = logInUser.Cname;
                //HttpContext.Session.SetString("userName", logInUser.Cname);
                //HttpContext.Session.SetString("userAccount", logInUser.CusrName);

                return RedirectToAction("Home", "Home");
            }

        }

        #endregion


    }
}