#region Includes

// .NET Libraries
using System.Collections.Generic;
using Infrastructure;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines various methods available to work with the <see cref="Address"/> repository in the system.
    /// </summary>
    public interface IAddressRepository
        : IRepository<Address, int>
    {
        /// <summary>
        /// Gets a collection of mailing address locations based on type and whether or not the record contains the address component value.
        /// </summary>
        /// <param name="addressComponentValue">The address component value to search for.</param>
        /// <param name="addressComponentType">The address component type (<see cref="TypeAddressComponent"/>).</param>
        /// <returns>An IEnumerable of mailing address instances.</returns>
        IEnumerable<Address> FindByAddressComponent(string addressComponentValue,
            TypeAddressComponent addressComponentType);
    }
}
