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

        /// <summary>
        /// Returns an object from the container when it exits.  Returns null otherwise.
        /// </summary>
        /// <returns>The object from the container when it exists, null otherwise.</returns>
        public T GetDataContext()
        {
            T context = null;

            if (_storedContexts.Contains(GetThreadName()))
                context = (T)_storedContexts[GetThreadName()];

            return context;
        }

        /// <summary>
        /// Stores the object in the hashtable indexed by the thread's name.
        /// </summary>
        /// <param name="objectContext">The object to store.</param>
        public void Store(T objectContext)
        {
            if (_storedContexts.Contains(GetThreadName()))
                _storedContexts[GetThreadName()] = objectContext;
            else
                _storedContexts.Add(GetThreadName(), objectContext);
        }

        /// <summary>
        /// Clears the object from the container.
        /// </summary>
        public void Clear()
        {
            if (_storedContexts.Contains(GetThreadName()))
                _storedContexts[GetThreadName()] = null;
        }

        #endregion
    }
}
