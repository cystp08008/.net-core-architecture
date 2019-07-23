using core.Services.CYSTP.Libs.Security.dotnet;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public class HomeService : IHomeService
    {
        #region Fields
        private readonly IEngRepository engRepository;
        private readonly IRightRepository rightRepository;
        private readonly IFavoriteFormRepository favoriteFormRepository;
        private readonly IRepository<FormGroup> formGroupRepository;
        private readonly IRepository<Tuser> tuserRepository;
        private readonly IRepository<UserBehaviorLog> userBehaviorLogRepository;
        private readonly IPasswordEncrypt passwordEncrypt;
        #endregion

        #region Ctor
        public HomeService(

            IEngRepository engRepository,
            IRepository<Tuser> tuserepository,
            IRightRepository rightRepository,
            IFavoriteFormRepository favoriteFormRepository,
            IRepository<FormGroup> formGroupRepository,
            IRepository<UserBehaviorLog> userBehaviorLogRepository,
            IPasswordEncrypt passwordEncrypt
            
            )
        {

            this.favoriteFormRepository = favoriteFormRepository;
            this.engRepository = engRepository;
            this.userBehaviorLogRepository = userBehaviorLogRepository;
            this.formGroupRepository = formGroupRepository;
            this.tuserRepository = tuserepository;
            this.rightRepository = rightRepository;
            this.passwordEncrypt = passwordEncrypt;


        }
        #endregion

        #region Utilities
        /// <summary>
        /// Get 頁面頂端導覽列 A資料維護
        /// </summary>
        /// <returns>主項目 A B C D</returns>
        public IQueryable<FormGroup> GetMain()
        {
            return this.formGroupRepository.Get(m => m.CParent == null).OrderBy(m => m.CNo);
        }
        /// <summary>
        /// Get 側邊導覽列 主項目 AA AB ... (依權限)
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="main">主項目(A資料維護)</param>
        /// <returns>側邊導覽列主項目</returns>
        public IQueryable<FormMain> GetMainMenu(string cusrName, string main)
        {
            return this.rightRepository.GetFormMainByRight(cusrName, main);
        }
        /// <summary>
        /// Get 側邊導覽列 子項目 AA01 AB01 ...(依權限)
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="mainMenu">子項目(AA01工令單)</param>
        /// <returns>側邊導覽列主項目</returns>
        public IQueryable<FormSub> GetSubMenu(string cusrName, string mainMenu)
        {
            return this.rightRepository.GetFormSubByRight(cusrName, mainMenu);
        }
        /// <summary>
        /// 修改密碼
        /// </summary>
        /// <param name="tuser">使用者Object</param>
        /// <param name="pwd">欲修改密碼</param>
        public void UpdatePwd(Tuser tuser, string pwd)
        {
            var setPwd = this.passwordEncrypt.HashPassword(pwd.Trim().ToLower());

            tuser.CusrPw = setPwd;

            tuser.Ichgpwd=(tuser.Ichgpwd == null) ? 1 : tuser.Ichgpwd + 1;

            this.tuserRepository.Update(tuser);

        }
        /// <summary>
        /// Check 工程是否為正確名稱
        /// </summary>
        /// <param name="eng">工程代號</param>
        /// <returns>Session需儲存的工程</returns>
        public string IsEng(string eng)
        {
            var checkEng = this.engRepository.GetFirst(m => m.CengId == eng);

            var setEng=(checkEng==null)?"":checkEng.CengId + " " + checkEng.CengSna;

            return setEng;
            
        }
        /// <summary>
        /// Insert 使用者使用的功能
        /// </summary>
        /// <param name="cusrName">使用者帳號</param>
        /// <param name="cfrmName">功能代號</param>
        public void CreateUserBehaviorLog(string cfrmName,string cusrName)
        {
            UserBehaviorLog userBehaviorLog = new UserBehaviorLog();

            userBehaviorLog.Cdate = DateTime.Now;
            userBehaviorLog.CfrmName = cfrmName;
            userBehaviorLog.CusrName = cusrName;

            this.userBehaviorLogRepository.Create(userBehaviorLog);
        }





        #endregion

    }
       

     


  }

