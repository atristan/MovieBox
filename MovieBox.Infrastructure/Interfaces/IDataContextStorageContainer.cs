namespace Infrastructure.Interfaces
{
    /// <summary>
    /// Defines methods to create, store and create objects from a storage container.
    /// </summary>
    /// <typeparam name="T">Specifies type.</typeparam>
    public interface IDataContextStorageContainer<T>
    {
        /// <summary>
        /// Returns an object from the container when it exists; returns null otherwise.
        /// </summary>
        /// <returns>The object from the container when it exists, otherwise null.</returns>
        T GetDataContext();

        /// <summary>
        /// Stores the object in HttpContext.Current.Items.
        /// </summary>
        /// <param name="objectContext">The object to store.</param>
        void Store(T objectContext);

        /// <summary>
        /// Clears the object from the container.
        /// </summary>
        void Clear();
    }
}
