using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models;
using DBClassLibrary.Models.ViewModel;

namespace core.Services
{
    public partial interface ITuserService
    {

        /// <summary>
        /// Get 登入者object
        /// </summary>
        /// <param name="cusrName">登入者輸入的密碼</param>
        /// <returns>登入帳號訊息</returns>
        Tuser GetTuser(string cusrName);

        /// <summary>
        ///Update 密碼
        /// </summary>
        /// <param name="tuser">使用者Object</param>
        /// <param name="pwd">欲修改密碼</param>
        void UpdatePwd(Tuser tuser, string pwd);

        /// <summary>
        /// Check 登入帳號密碼
        /// </summary>
        /// <param name="logInUser">欲帳號Tuser Object</param>
        /// <param name="cusrPw">該帳號正確加密密碼</param>
        /// <returns>密碼是否吻合</returns>
        bool ValidatePassword(Tuser logInUser, string cusrPw);
    }
}
