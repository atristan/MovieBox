#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Linq;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// A concrete repository to work with customers in the system.
    /// </summary>
    public class CustomerRepository
        : Repository<Customer>, ICustomerRepository
    {
        #region ICustomerRepository Members

        /// <inheritdoc />
        public IEnumerable<Customer> FindBy(DateTime memberStartDate)
        {
            return DataContextFactory.GetDataContext().Set<Customer>().Where(x => x.MemberStartDate == memberStartDate);
        }

        /// <inheritdoc />
        public Customer FindByCustomerId(string customerId)
        {
            return DataContextFactory.GetDataContext().Set<Customer>().FirstOrDefault(x => x.CustomerId == customerId);
        }

        #endregion
    }
}
