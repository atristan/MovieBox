#region Includes

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Defines a unit of work using an EF DbContext under the hood.
    /// </summary>
    public class UnitOfWork
        : IUnitOfWork
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of UnitOfWork in the system.
        /// </summary>
        /// <param name="forceNewContext">When <c>true</c>, clears out any existing data context first.</param>
        public UnitOfWork(bool forceNewContext)
        {
            if(forceNewContext)
                DataContextFactory.Clear();
        }

        #endregion

        #region IUnitOfWork Members

        /// <summary>
        /// Saves the chnages to the underlying DbContext.
        /// </summary>
        public void Dispose()
        {
            DataContextFactory.GetDataContext().SaveChanges();
        }

        /// <summary>
        /// Saves the chnages to the underlying DbContext.
        /// </summary>
        /// <param name="resetAfterCommit">When <c>true</c>, clears out the data context afterwards.</param>
        public void Commit(bool resetAfterCommit)
        {
            DataContextFactory.GetDataContext().SaveChanges();

            if(resetAfterCommit)
                DataContextFactory.Clear();
        }

        /// <summary>
        /// Undoes the changes to the current DbContext by removing it from the storage container.
        /// </summary>
        public void Undo()
        {
            DataContextFactory.Clear();
        }

        #endregion
    }
}
