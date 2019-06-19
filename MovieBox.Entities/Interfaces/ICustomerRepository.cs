#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines varioius methods available to work with the <see cref="Customer"/> repository in the system.
    /// </summary>
    public interface ICustomerRepository
        : IRepository<Customer, int>
    {
        /// <summary>
        /// Gets a collection of customers based on a start date.
        /// </summary>
        /// <param name="memberStartDate">The start date to search for.</param>
        /// <returns>An IEnumerable of <see cref="Customer"/> instances.</returns>
        IEnumerable<Customer> FindBy(DateTime memberStartDate);

        /// <summary>
        /// Gets a customer from the repository by their customer id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Customer FindByCustomerId(string customerId);
    }
}
