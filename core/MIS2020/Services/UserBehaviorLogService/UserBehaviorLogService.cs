using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;

namespace core.Services
{
    public class UserBehaviorLogService : IUserBehaviorLogService
    {
        #region Fields
        private readonly IRepository<UserBehaviorLog> userBehaviorLogRepository;
        #endregion

        #region Ctor
        public UserBehaviorLogService(

            IRepository<UserBehaviorLog> userBehaviorLogRepository

            )
        {

            this.userBehaviorLogRepository = userBehaviorLogRepository;
        }
        #endregion

        #region Utilities

        /// <summary>
        /// Insert 使用者使用的功能
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="cfrmName">功能代號</param>
        public void CreateUserBehaviorLog(string cfrmName, string cusrName)
        {
            UserBehaviorLog userBehaviorLog = new UserBehaviorLog
            {
                Cdate = DateTime.Now,
                CfrmName = cfrmName,
                CusrName = cusrName
            };

            this.userBehaviorLogRepository.Create(userBehaviorLog);
        }



        #endregion
    }
}
