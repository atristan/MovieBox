#region Includes

// MovieBox Libraries
using Infrastructure;
using MovieBox.DataAccess;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Manages instances of the MovieBoxContext and stores them in an appropriate storage container.
    /// </summary>
    public static class DataContextFactory
    {
        #region Methods

        /// <summary>
        /// Clears out the current context.
        /// </summary>
        public static void Clear()
        {
            var container = DataContextStorageFactory<MovieBoxContext>.CreateStorageContainer();
            container.Clear();
        }

        /// <summary>
        /// Gets an instance of MovieBoxContext from the appropriate storage container or creates a new instance and stores that in a container.
        /// </summary>
        /// <returns>An instance of <see cref="MovieBoxContext"/>.</returns>
        public static MovieBoxContext GetDataContext()
        {
            var container = DataContextStorageFactory<MovieBoxContext>.CreateStorageContainer();
            var context = container.GetDataContext();

            if (context == null)
            {
                context = new MovieBoxContext();
                container.Store(context);
            }

            return context;
        }

        #endregion
    }
}
