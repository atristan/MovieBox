#region Includes

// .NET Libraries
using System.Web;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Infrastructure
{
    /// <summary>
    /// A Helper class to store objects like a DataContext in the HttpContext.Current.Items collection.
    /// </summary>
    /// <typeparam name="T">Specifies the type of object to store.</typeparam>
    public class HttpDataContextContainer<T>
        : IDataContextStorageContainer<T> where T : class
    {
        #region Member Fields

        private const string _dataContextKey = "DataContext";

        #endregion

        #region IDataContextStorageContainer Members

        /// <summary>
        /// Returns an object from the container when it exists.  Returns null otherwise.
        /// </summary>
        /// <returns>The object from the container when it exists, otherwise null.</returns>
        public T GetDataContext()
        {
            T objectContext = null;
            if (HttpContext.Current.Items.Contains(_dataContextKey))
                objectContext = (T)HttpContext.Current.Items[_dataContextKey];

            return objectContext;
        }

        /// <summary>
        /// Stores the object in HttpContext.Current.Items.
        /// </summary>
        /// <param name="objectContext">The object to store.</param>
        public void Store(T objectContext)
        {
            if (HttpContext.Current.Items.Contains(_dataContextKey))
                HttpContext.Current.Items[_dataContextKey] = objectContext;
            else
                HttpContext.Current.Items.Add(_dataContextKey, objectContext);
        }

        /// <summary>
        /// Clears the object from the container.
        /// </summary>
        public void Clear()
        {
            if (HttpContext.Current.Items.Contains(_dataContextKey))
                HttpContext.Current.Items[_dataContextKey] = null;
        }

        #endregion
    }
}
