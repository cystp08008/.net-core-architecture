using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models.ViewModel;
using DBClassLibrary.Models;
namespace core.Services
{
    public partial interface IWebLoginService
    {

        /// <summary>
        /// Insert WebLogIn登入訊息(成功)
        /// </summary>
        /// <param name="cusrName">欲帳號Tuser Object</param>
        /// <param name="cname">登入者姓名</param>
        ///
        void CreateWebLogin(Tuser tuser, string IpAddress);
        /// <summary>
        /// Insert WebLogIn登入訊息(失敗)
        /// </summary>
        /// <param name="cusrName">登入者輸入的帳號</param>
        ///
        void CreateWebLogin(string cusrName, string IpAddress);


    }
}
