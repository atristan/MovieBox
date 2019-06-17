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
    public static class DataContextStorageFactory<T>
        where T : class
    {
        #region Fields

        private static IDataContextStorageContainer<T> _currentContextContainer;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the current data context storage container instance.
        /// </summary>
        public static IDataContextStorageContainer<T> CurrentContextContainer
        {
            get => _currentContextContainer ?? (_currentContextContainer = CreateStorageContainer());
            set => _currentContextContainer = value;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clears out the current data storage context.
        /// </summary>
        public static void Clear()
        {
            CurrentContextContainer.Clear();
        }

        /// <summary>
        /// Creates a new container that uses HttpContext.Current.Items when it is not null, 
        /// otherwise Thread.Items.
        /// </summary>
        /// <returns>A contact storage container to store objects.</returns>
        public static IDataContextStorageContainer<T> CreateStorageContainer()
        {
            if (_currentContextContainer == null)
            {
                if (HttpContext.Current == null)
                    _currentContextContainer = new ThreadDataContextStorageContainer<T>();
                else
                    _currentContextContainer = new HttpDataContextContainer<T>();
            }
            return _currentContextContainer;
        }

        #endregion
    }
}
