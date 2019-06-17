#region Includes

// .NET Libraries
using System;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents a customer in the system.
    /// </summary>
    public class Customer
        : Person
    {
        #region Members

        /// <summary>
        /// Gets or sets the date the customer became a member.
        /// </summary>
        public DateTime AnniversaryDate { get; set; }

        /// <summary>
        /// Gets or sets the customer id for the person.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets a collection of rental history for the person.
        /// </summary>
        public Rentals RentalHistory { get; set; }

        #endregion
    }
}
