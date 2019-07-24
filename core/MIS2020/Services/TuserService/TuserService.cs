using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;

namespace core.Services
{
    public class TuserService : ITuserService
    {
        #region Fields
        private readonly IRepository<Tuser> tuserRepository;
        private readonly IPasswordEncryptService passwordEncryptService;
        #endregion

        #region Ctor
        public TuserService(IRepository<Tuser> tuserepository, IPasswordEncryptService passwordEncryptService)
        {

            this.tuserRepository = tuserepository;
            this.passwordEncryptService = passwordEncryptService;

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
        /// 修改密碼
        /// </summary>
        /// <param name="tuser">使用者Object</param>
        /// <param name="pwd">欲修改密碼</param>
        public void UpdatePwd(Tuser tuser, string pwd)
        {
            var setPwd = this.passwordEncryptService.HashPassword(pwd.Trim().ToLower());

            tuser.CusrPw = setPwd;

            tuser.Ichgpwd = (tuser.Ichgpwd == null) ? 1 : tuser.Ichgpwd + 1;

            this.tuserRepository.Update(tuser);

        }


        /// <summary>
        ///Check  登入帳號密碼
        /// </summary>
        /// <param name="logInUser">欲帳號Tuser Object</param>
        /// <param name="cusrPw">該帳號正確加密密碼</param>
        /// <returns>密碼是否吻合</returns>
        public bool ValidatePassword(Tuser logInUser, string cusrPw)
        {
            return (logInUser == null) ? false : this.passwordEncryptService.ValidatePassword(cusrPw, logInUser.CusrPw);
        }


        #endregion
    }
}
