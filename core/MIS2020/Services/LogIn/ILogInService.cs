using DBClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services.LogIn
{
    /// <summary>
    /// LogIn service interface
    /// </summary>
    public partial interface ILogInService
    {
        /// <summary>
        /// Get 登入者object
        /// </summary>
        /// <param name="cusrName">登入者輸入的密碼</param>
        /// <returns>登入帳號訊息</returns>
        Tuser GetTuser(string cusrName);
        /// <summary>
        /// Check 登入帳號密碼
        /// </summary>
        /// <param name="logInUser">欲帳號Tuser Object</param>
        /// <param name="cusrPw">該帳號正確加密密碼</param>
        /// <returns>密碼是否吻合</returns>
        bool ValidatePassword(Tuser logInUser, string cusrPw);
        /// <summary>
        /// Insert WebLogIn登入訊息(成功)
        /// </summary>
        /// <param name="cusrName">欲帳號Tuser Object</param>
        /// <param name="cname">登入者姓名</param>
        ///
        void CreateWebLogin(Tuser tuser,string IpAddress);
        /// <summary>
        /// Insert WebLogIn登入訊息(失敗)
        /// </summary>
        /// <param name="cusrName">登入者輸入的帳號</param>
        ///
        void CreateWebLogin(string cusrName, string IpAddress);

       








    }
}
