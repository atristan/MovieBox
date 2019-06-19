#region Includes

// .NET Libraries
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines various methods available to work with the <see cref="Email"/> repository in the system.
    /// </summary>
    public interface IEmailRepository
        : IRepository<Email, int>
    {
        /// <summary>
        /// Searches email addresses in the repository for emails that contain the search string.
        /// </summary>
        /// <param name="emailContains">Search key.</param>
        /// <returns>Returns a collection of emails that contain the search key, otherwise null.</returns>
        IEnumerable<Email> FindAllBy(string emailContains);
    }
}
