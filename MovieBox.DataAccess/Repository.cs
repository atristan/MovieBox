#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// MovieBox Libraries
using Infrastructure;
using Infrastructure.Interfaces;

#endregion

namespace DataAccess
{
    public abstract class Repository<T>
        : IRepository<T, int>, IDisposable where T : DomainEntity<int>
    {
        #region IRepository Members
        
        public T FindById(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>>[] predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if(DataContextStorageFactory.CreateStorageContainer() != null)
                DataContextStorageFactory<T>.CreateStorageContainer().d
        }

        #endregion
    }
}
