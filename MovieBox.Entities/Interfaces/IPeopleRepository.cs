#region Includes

// .NET Libraries
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines various methods available to work with tje <see cref="T:Entities.Person" /> repository in the system.
    /// </summary>
    public interface IPeopleRepository
        : IRepository<Person, int>
    {
        /// <summary>
        /// Gets a list of all the people whose last name exactly matches the search string.
        /// </summary>
        /// <param name="lastName">The last name to search for.</param>
        /// <returns>A collection of <see cref="Person"/> instances whose name matches the search string.</returns>
        IEnumerable<Person> FindByLastName(string lastName);
    }
}
