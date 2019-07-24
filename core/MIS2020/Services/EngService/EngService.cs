using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public class EngService : IEngService
    {
        #region Fields
        private readonly IEngRepository engRepository;
        #endregion

        #region Ctor
        public EngService
        (

            IEngRepository engRepository
            
        )

        {
            this.engRepository = engRepository;
        }
        #endregion

        #region Utilities

        /// <summary>
        /// Check 工程是否為正確名稱
        /// </summary>
        /// <param name="eng">工程代號</param>
        /// <returns>Session需儲存的工程</returns>
        public string IsEng(string eng)
        {
            var checkEng = this.engRepository.GetFirst(m => m.CengId == eng);

            var setEng = (checkEng == null) ? "" : checkEng.CengId + " " + checkEng.CengSna;

            return setEng;

        }



        #endregion
    }
}
