using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using core.Services.CYSTP.Libs.Security.dotnet;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using IdentityModel.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace core.Services.LogIn
{
    public class LogInService : ILogInService
    {
        #region Fields
        private readonly IRepository<Tuser> tuserRepository;
        private readonly IRepository<WebLogin> webLoginRepository;
        private readonly IPasswordEncrypt passwordEncrypt;

        #endregion

        #region Ctor
        public LogInService(
            
            IRepository<Tuser> tuserepository,
            IRepository<WebLogin> webLoginRepository, 
            IPasswordEncrypt passwordEncrypt
            
            )
        {
            this.tuserRepository = tuserepository;
            this.webLoginRepository = webLoginRepository;
            this.passwordEncrypt = passwordEncrypt;
        }

        #endregion


        #region Utilities
        /// <summary>
        ///Check 登入帳號密碼
        /// </summary>
        /// <param name="cusrName">登入者輸入的密碼</param>
        /// <returns>登入帳號訊息</returns>

        public Tuser GetTuser(string cusrName)
        {
            return this.tuserRepository.GetFirst(m => m.CusrName == cusrName); 
        }
        /// <summary>
        ///Check  登入帳號密碼
        /// </summary>
        /// <param name="logInUser">欲帳號Tuser Object</param>
        /// <param name="cusrPw">該帳號正確加密密碼</param>
        /// <returns>密碼是否吻合</returns>
        public bool ValidatePassword(Tuser logInUser, string cusrPw)
        {
            return (logInUser == null) ? false : this.passwordEncrypt.ValidatePassword(cusrPw, logInUser.CusrPw);
        }
        /// <summary>
        /// Insert WebLogIn登入訊息(成功)
        /// </summary>
        /// <param name="cusrName">欲帳號Tuser Object</param>
        /// <param name="cname">登入者姓名</param>
        ///
        public void CreateWebLogin(Tuser tuser, string IpAddress)
        {
            WebLogin webLogin = new WebLogin();

            webLogin.Cdate = DateTime.Now;
            webLogin.Cname = tuser.Cname;
            webLogin.CusrName = tuser.CusrName;
            webLogin.Issuccess = true;
            webLogin.IpAddress = IpAddress;

            this.webLoginRepository.Create(webLogin);
        }
        /// <summary>
        /// Insert WebLogIn登入訊息(失敗)
        /// </summary>
        /// <param name="cusrName">登入者輸入的帳號</param>
        ///
        public void CreateWebLogin(string cusrName,string IpAddress)
        {
            WebLogin webLogin = new WebLogin();

            webLogin.Cdate = DateTime.Now;
            webLogin.Cname = "";
            webLogin.CusrName = cusrName;
            webLogin.Issuccess = false;
            webLogin.IpAddress = IpAddress;
            this.webLoginRepository.Create(webLogin);
        }
        #endregion




    }
}
