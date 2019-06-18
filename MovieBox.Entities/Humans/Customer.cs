#region Includes

// .NET Libraries
using System;
using System.ComponentModel.DataAnnotations;

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
        public DateTime MemberStartDate { get; set; }

        /// <summary>
        /// Gets or sets the customer id for the person.
        /// </summary>
        [Required]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets a collection of rental history for the person.
        /// </summary>
        public Rentals RentalHistory { get; set; }

        #endregion
    }
}
