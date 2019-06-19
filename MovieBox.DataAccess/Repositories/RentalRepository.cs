#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// A concrete repository to work with rentals in the system.
    /// </summary>
    public class RentalRepository
        : Repository<Rental>, IRentalRepository
    {
        /// <inheritdoc />
        public Rental FindByTrackingId(string id)
        {
            return DataContextFactory.GetDataContext().Set<Rental>().FirstOrDefault(x => x.TrackingId == id);
        }

        /// <inheritdoc />
        public IEnumerable<Rental> FindBy(DateTime dateRented)
        {
            return DataContextFactory.GetDataContext().Set<Rental>().Where(x => x.DateRented == dateRented);
        }
    }
}
