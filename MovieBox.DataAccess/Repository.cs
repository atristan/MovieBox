#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

// MovieBox Libraries
using Infrastructure;
using Infrastructure.Interfaces;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Serves as a generic base class for concrete repositories to support basic CRUD operations on data in the system.
    /// </summary>
    /// <typeparam name="T">The type of entity this repository works with.  Must be a class inheriting <see cref="DomainEntity{T}"/>.</typeparam>
    public abstract class Repository<T>
        : IRepository<T, int>, IDisposable where T : DomainEntity<int>
    {
        #region IRepository Members
        
        /// <summary>
        /// Finds an item by its unique id in the system.
        /// </summary>
        /// <param name="id">The unique id of the item in the database.</param>
        /// <param name="includeProperties">
        /// An expression of additional properties to eager load.
        /// Ex.:
        ///     x => x.Addresses, x => x.Emails
        /// </param>
        /// <returns>An instance of type T with the approrpriate data, or null otherwise.</returns>
        public T FindById(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Returns an IQueryable of all items of type T.
        /// </summary>
        /// <param name="includeProperties">
        /// An expression of additional properties to eager load.
        /// Ex.:
        ///     x => x.Addresses, x => x.Emails
        /// </param>
        /// <returns>An IQueryable of type T.</returns>
        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = DataContextFactory.GetDataContext().Set<T>();

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                    items = items.Include(includeProperty);
            }

            return items;
        }

        /// <summary>
        /// Returns an IEnumerable of items of type T.
        /// </summary>
        /// <param name="predicate">A predicate to limite the items being returned.</param>
        /// <param name="includeProperties">
        /// An expression of additional properties to eager load.
        /// Ex.:
        ///     x => x.Addresses, x => x.Emails
        /// </param>
        /// <returns>An IEnumerable of the requested type T.</returns>
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = DataContextFactory.GetDataContext().Set<T>();

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                    items = items.Include(includeProperty);
            }

            return items.Where(predicate);
        }

        /// <summary>
        /// Adds an entity to the underlying DbContext.
        /// </summary>
        /// <param name="entity">The entity that should be added.</param>
        public void Add(T entity)
        {
            DataContextFactory.GetDataContext().Set<T>().Add(entity);
        }

        /// <summary>
        /// Removes an entityt from the underlying DbContext.
        /// </summary>
        /// <param name="entity">The entityt that should be removed.</param>
        public void Remove(T entity)
        {
            DataContextFactory.GetDataContext().Set<T>().Remove(entity);
        }

        /// <summary>
        /// Removes an entity from the underlying DbContext.  Calls <see cref="FindById"/> to resolve the item.
        /// </summary>
        /// <param name="id">The id of the entity that should be removed.</param>
        public void Remove(int id)
        {
            Remove(FindById(id));
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Disposes the underlying data context.
        /// </summary>
        public void Dispose()
        {
            if(DataContextFactory.GetDataContext() != null)
                DataContextFactory.GetDataContext().Dispose();
        }

        #endregion
    }
}
