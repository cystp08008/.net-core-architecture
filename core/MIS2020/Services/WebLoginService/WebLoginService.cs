using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;

namespace core.Services
{
    public class WebLoginService : IWebLoginService
    {
        #region Fields
        private readonly IRepository<WebLogin> webLoginRepository;
        #endregion

        #region Ctor
        public WebLoginService(

            IRepository<WebLogin> webLoginRepository

            )
        {

            this.webLoginRepository = webLoginRepository;
        }
        #endregion

        #region Utilities

        /// <summary>
        /// Insert WebLogIn登入訊息(成功)
        /// </summary>
        /// <param name="cusrName">欲帳號Tuser Object</param>
        /// <param name="cname">登入者姓名</param>
        ///
        public void CreateWebLogin(Tuser tuser, string IpAddress)
        {
            var webLogin = new WebLogin
            {

                Cdate = DateTime.Now,
                Cname = tuser.Cname,
                CusrName = tuser.CusrName,
                Issuccess = true,
                IpAddress = IpAddress
            };

            this.webLoginRepository.Create(webLogin);
        }
        /// <summary>
        /// Insert WebLogIn登入訊息(失敗)
        /// </summary>
        /// <param name="cusrName">登入者輸入的帳號</param>
        ///
        public void CreateWebLogin(string cusrName, string IpAddress)
        {
            var webLogin = new WebLogin
            {

                Cdate = DateTime.Now,
                Cname = "",
                CusrName = cusrName,
                Issuccess = false,
                IpAddress = IpAddress

            };

            this.webLoginRepository.Create(webLogin);
        }




        #endregion
    }
}
