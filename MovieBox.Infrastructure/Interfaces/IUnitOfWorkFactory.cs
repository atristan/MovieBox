namespace Infrastructure.Interfaces
{
    /// <summary>
    /// Defines a contract for implementing unit of work factory operations.
    /// </summary>
    public interface IUnitOfWorkFactory
    {
        /// <summary>
        /// Creates a new instance of a unit of work.
        /// </summary>
        /// <returns></returns>
        IUnitOfWork Create();

        /// <summary>
        /// Creates a new instance of a unit of work.
        /// </summary>
        /// <param name="forceNew">
        /// When true, clears out any existing in-memory data storage/cache first.
        /// </param>
        /// <returns></returns>
        IUnitOfWork Create(bool forceNew);
    }
}
