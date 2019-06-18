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
        /// Finds a Company by their unique ID in the system.
        /// </summary>
        /// <param name="id">The unique ID of the Company in the system.</param>
        /// <returns>A single instance of <see cref="Company"/> from the repository, otherwise returns null.</returns>
        Company FindById(int id);

        /// <summary>
        /// Finds all instances of companies with the specified name.
        /// </summary>
        /// <param name="key">The name to search for.</param>
        /// <returns>A collection of instances with the name specified.</returns>
        IEnumerable<Company> FindBy(string key);

        /// <summary>
        /// Deletes an instance of <see cref="Company"/> from the repository.
        /// </summary>
        /// <param name="id">The ID of the instance to delete.</param>
        void DeleteById(int id);

        /// <summary>
        /// Saves an instance of <see cref="Company"/> to the repository.
        /// </summary>
        /// <param name="instance">The instance to save.</param>
        void Save(Company instance);
    }
}
