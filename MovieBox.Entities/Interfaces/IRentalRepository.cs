#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    public interface IRentalRepository
        : IRepository<Rental, int>
    {
        /// <summary>
        /// Gets a single <see cref="Rental"/> by the rental ID.
        /// </summary>
        /// <param name="id">The tracking id of the rental.</param>
        /// <returns>A single instance of <see cref="Rental"/> if the id exists, otherwise null.</returns>
        Rental FindByTrackingId(string id);

        /// <summary>
        /// Gets a collection of rentals by due date.
        /// </summary>
        /// <param name="dateRented"></param>
        /// <returns></returns>
        IEnumerable<Rental> FindBy(DateTime dateRented);
    }
}
