#region Includes

// .NET Libraries
using System;
using System.Collections;
using System.Threading;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Infrastructure
{
    /// <summary>
    /// A helper class to store objects like a DataContext in a static HastTable inexed by the name of a thread.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ThreadDataContextStorageContainer<T>
        : IDataContextStorageContainer<T> where T : class
    {
        #region Member Fields

        private static readonly Hashtable _storedContexts = new Hashtable();

        #endregion

        #region Member Methods

        /// <summary>
        /// Gets a threads name; if string is empty, assigns a guid name.
        /// </summary>
        /// <returns>A guid string.</returns>
        private static string GetThreadName()
        {
            if (string.IsNullOrEmpty(Thread.CurrentThread.Name))
                Thread.CurrentThread.Name = Guid.NewGuid().ToString();

            return Thread.CurrentThread.Name;
        }

        #endregion

        #region IDataContextStorageContainer Members

        /// <inheritdoc />
        public T GetDataContext()
        {
            T context = null;

            if (_storedContexts.Contains(GetThreadName()))
                context = (T)_storedContexts[GetThreadName()];

            return context;
        }

        /// <inheritdoc />
        public void Store(T objectContext)
        {
            if (_storedContexts.Contains(GetThreadName()))
                _storedContexts[GetThreadName()] = objectContext;
            else
                _storedContexts.Add(GetThreadName(), objectContext);
        }

        /// <inheritdoc />
        public void Clear()
        {
            if (_storedContexts.Contains(GetThreadName()))
                _storedContexts[GetThreadName()] = null;
        }

        #endregion
    }
}
