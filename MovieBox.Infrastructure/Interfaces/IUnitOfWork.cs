#region Includes

// .NET Libraries
using System;

#endregion

namespace Infrastructure.Interfaces
{
    /// <summary>
    /// Defines a contract for implementing unit of work operations.
    /// </summary>
    public interface IUnitOfWork
        : IDisposable
    {
        /// <summary>
        /// Commits the changes to the underlying data store.
        /// </summary>
        /// <param name="resetAfterCommit"></param>
        void Commit(bool resetAfterCommit);

        /// <summary>
        /// Undoes all changes to the entities in the model.
        /// </summary>
        void Undo();
    }
}
