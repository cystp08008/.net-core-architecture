using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public partial interface IEngService
    {

        /// <summary>
        /// Check 工程是否為正確名稱
        /// </summary>
        /// <param name="eng">工程代號</param>
        /// <returns>Session需儲存的工程</returns>
        string IsEng(string eng);
    }
}
