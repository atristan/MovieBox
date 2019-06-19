#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure;
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines various methods available to work with the <see cref="PhoneNumber"/> repository in the system.
    /// </summary>
    public interface IPhoneNumberRepository
        : IRepository<PhoneNumber, int>
    {
        /// <summary>
        /// Provides ability to search phone numbers by one of the number components specified in <see cref="TypePhoneNumberComponent"/> enum.
        /// </summary>
        /// <param name="numberComponentValue">The value to search for.</param>
        /// <param name="numberComponentType">The field to search against.</param>
        /// <returns></returns>
        IEnumerable<PhoneNumber> FindAllBy(int numberComponentValue, TypePhoneNumberComponent numberComponentType);
    }
}
