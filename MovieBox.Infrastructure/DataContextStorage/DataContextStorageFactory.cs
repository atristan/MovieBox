#region Includes

// .NET Libraries
using System.Web;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Infrastructure
{
    /// <summary>
    /// A Helper class to create application platform specific storage containers.
    /// </summary>
    /// <typeparam name="T">The type for which to create the container.</typeparam>
    public class DataContextStorageFactory<T>
        where T : class
    {
        #region Fields

        private static IDataContextStorageContainer<T> _dataContextStorageContainer;

        #endregion

        #region Methods

        /// <summary>
        /// Creates a new container that uses HttpContext.Current.Items when it is not null, 
        /// otherwise Thread.Items.
        /// </summary>
        /// <returns>A contact storage container to store objects.</returns>
        public static IDataContextStorageContainer<T> CreateStorageContainer()
        {
            if (_dataContextStorageContainer == null)
            {
                if (HttpContext.Current == null)
                    _dataContextStorageContainer = new ThreadDataContextStorageContainer<T>();
                else
                    _dataContextStorageContainer = new HttpDataContextContainer<T>();
            }
            return _dataContextStorageContainer;
        }

        #endregion
    }
}
