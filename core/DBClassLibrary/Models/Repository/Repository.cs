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
        private readonly Bom2013Context _Bom2013Context;
        public Repository(Bom2013Context Bom2013Context)
        {
            _Bom2013Context = Bom2013Context;
        }
        public void Create(T entity)
        {
            _Bom2013Context.Set<T>().Add(entity);
            _Bom2013Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _Bom2013Context.Set<T>().Remove(entity);
            _Bom2013Context.SaveChanges();
        }


        public IEnumerable<T> Get()
        {
            return _Bom2013Context.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _Bom2013Context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public T GetFirst(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _Bom2013Context.Set<T>().Where(predicate).FirstOrDefault<T>();
        }

        public void Update(T entity)
        {
            _Bom2013Context.Entry(entity).State = EntityState.Modified;
            _Bom2013Context.SaveChanges();
        }
    }
}
