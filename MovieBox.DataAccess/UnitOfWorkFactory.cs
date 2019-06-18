#region Includes

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Creates a new instance of a <see cref="UnitOfWork"/> in the system.
    /// </summary>
    public class UnitOfWorkFactory
        : IUnitOfWorkFactory
    {
        #region IUniteOfWorkFactory Members

        /// <inheritdoc />
        public IUnitOfWork Create()
        {
            return Create(false);
        }

        /// <inheritdoc />
        public IUnitOfWork Create(bool forceNew)
        {
            return new UnitOfWork(forceNew);
        }

        #endregion
    }
}
