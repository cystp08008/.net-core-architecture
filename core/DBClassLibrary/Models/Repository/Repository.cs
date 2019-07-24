using core.Models;
using DBClassLibrary.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClassLibrary.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Fields
        private readonly Bom2013Context _Bom2013Context;
        #endregion

        #region Ctor
        public Repository(Bom2013Context Bom2013Context)
        {
            _Bom2013Context = Bom2013Context;
        }
        #endregion

        #region Utilities

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public void Create(T entity)
        {
            _Bom2013Context.Set<T>().Add(entity);
            _Bom2013Context.SaveChanges();
        }
        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public void Delete(T entity)
        {
            _Bom2013Context.Set<T>().Remove(entity);
            _Bom2013Context.SaveChanges();
        }

        /// <summary>
        /// Get 該表(無條件)
        /// </summary>
        public IQueryable<T> Get()
        {
            return _Bom2013Context.Set<T>().AsQueryable<T>();
        }
        /// <summary>
        /// Get 該表(需含條件)
        /// <param>條件</param>
        /// </summary>
        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _Bom2013Context.Set<T>().Where(predicate).AsQueryable<T>();
        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public void Update(T entity)
        {
            _Bom2013Context.Entry(entity).State = EntityState.Modified;
            _Bom2013Context.SaveChanges();
        }
        /// <summary>
        /// Get entity by identifier(條件)單筆
        /// </summary>
        /// <param>條件</param>
        /// <returns>Entity</returns>
        public T GetFirst(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _Bom2013Context.Set<T>().Where(predicate).FirstOrDefault<T>();
        }

        #endregion
    }
}
