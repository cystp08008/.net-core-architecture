using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services
{
    public class FormGroupService : IFormGroupService
    {
        #region Fields
        private readonly IRepository<FormGroup> formGroupRepository;
        #endregion

        #region Ctor
        public FormGroupService
        (
            IRepository<FormGroup> formGroupRepository

        )
        {
            this.formGroupRepository = formGroupRepository;

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



        #endregion
    }
}
