using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models.ViewModel;

namespace core.Services
{
    public partial interface IUserBehaviorLogService
    {
        /// <summary>
        /// Insert 使用者使用的功能
        /// </summary>
        /// <param name="cfrmName">功能代號</param>
        /// <param name="cusrName">使用者帳號</param>
        void CreateUserBehaviorLog(string cfrmName, string cusrName);
    }
}
