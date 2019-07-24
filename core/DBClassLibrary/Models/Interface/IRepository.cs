using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DBClassLibrary.Models.Interface
{
    public interface IRepository<T> where T : class
    {
        #region Properties 多筆
        /// <summary>
        /// Get 該表(無條件)
        /// </summary>
        IQueryable<T> Get();
        /// <summary>
        /// Get 該表(需含條件)
        /// <param>條件</param>
        /// </summary>
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        #endregion
        #region Methods
        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Create(T entity);
        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Delete(T entity);
        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Update(T entity);
        #endregion

        /// <summary>
        /// Get entity by identifier(條件)
        /// </summary>
        /// <param>Identifier</param>
        /// <returns>Entity</returns>
        T GetFirst(Expression<Func<T, bool>> predicate);

    }
}
