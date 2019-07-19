using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.SessionExtensions;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MIS2020.Services.PasswordEncrypt;

namespace core.Controllers
{
    public class LogInController : Controller
    {
        //DB
        private readonly IRepository<Tuser> tuserRepository;
        private readonly IRepository<WebLogin> webLoginRepository;
        //Service
        private readonly IPasswordEncrypt passwordEncrypt;


        public LogInController(IRepository<Tuser> tuserepository, IRepository<WebLogin> webLoginRepository, IPasswordEncrypt passwordEncrypt)
        {
            this.tuserRepository = tuserepository;
            this.webLoginRepository = webLoginRepository;
            this.passwordEncrypt = passwordEncrypt;
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(Tuser tuser)
        {
            WebLogin webLogin = new WebLogin();
            PasswordEncrypt passwordEncrypt = new PasswordEncrypt();

            var logInUser = this.tuserRepository.GetFirst(m=>m.CusrName== tuser.CusrName);

            //驗證密碼 加密後 是否與 資料庫加密 密碼 符合
            var tResult = (logInUser == null) ? false : this.passwordEncrypt.ValidatePassword(tuser.CusrPw, logInUser.CusrPw);

            if (!tResult)
            {
                ViewBag.Mess = "帳號密碼錯誤";

                webLogin.Cdate = DateTime.Now;
                webLogin.Cname = "";
                webLogin.CusrName = tuser.CusrName;
                webLogin.Issuccess = false;
                webLogin.IpAddress = "";
                this.webLoginRepository.Create(webLogin);
                return View();
            }
            else
            {
                


                //Session 儲存 使用者 object
                HttpContext.Session.SetObject("user", logInUser);


                webLogin.Cdate = DateTime.Now;
                webLogin.Cname = logInUser.Cname;
                webLogin.CusrName = tuser.CusrName;
                webLogin.Issuccess = true;
                webLogin.IpAddress = "";

                this.webLoginRepository.Create(webLogin);

                return RedirectToAction("Home", "Home");
            }
                
        }



    }
}