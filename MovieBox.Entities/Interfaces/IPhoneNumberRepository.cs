#region Includes

// .NET Libraries
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines various methods available to work with tje <see cref="PhoneNumber"/> repository in the system.
    /// </summary>
    public interface IPhoneNumberRepository
        : IRepository<PhoneNumber, int>
    {
        /// <summary>
        /// Finds a person by their unique ID in the system.
        /// </summary>
        /// <param name="id">The unique ID of the person in the system.</param>
        /// <returns>A single instance of <see cref="PhoneNumber"/> from the repository, otherwise returns null.</returns>
        PhoneNumber FindById(int id);

        /// <summary>
        /// Finds all instances of people with the specified name.
        /// </summary>
        /// <param name="key">The name to search for.</param>
        /// <returns>A collection of instances with the name specified.</returns>
        IEnumerable<PhoneNumber> FindBy(string key);

        /// <summary>
        /// Deletes an instance of <see cref="PhoneNumber"/> from the repository.
        /// </summary>
        /// <param name="id">The ID of the instance to delete.</param>
        void DeleteById(int id);

        /// <summary>
        /// Saves an instance of <see cref="PhoneNumber"/> to the repository.
        /// </summary>
        /// <param name="instance"></param>
        void Save(PhoneNumber instance);
    }
}
