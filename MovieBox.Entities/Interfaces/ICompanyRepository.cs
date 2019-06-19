#region Includes

// .NET Libraries
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines various methods available to work with the <see cref="Company"/> repository in the system.
    /// </summary>
    public interface ICompanyRepository
        : IRepository<Company, int>
    {
        /// <summary>
        /// Finds matches for companies in the system that contain the name.
        /// </summary>
        /// <param name="name">The name to search for.</param>
        /// <returns>A collection of instances of <see cref="Company"/> from the repository, otherwise returns null.</returns>
        IEnumerable<Company> FindByName(string name);
    }
}
