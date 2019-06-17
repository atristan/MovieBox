#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents a US-based company in the system.
    /// </summary>
    public class Company
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a collection of <see cref="Emails"/> for this company.
        /// </summary>
        public Emails EmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets a collection of <see cref="PhoneNumbers"/> for this company.
        /// </summary>
        public PhoneNumbers Numbers { get; set; }

        /// <summary>
        /// Gets or sets a collection of <see cref="Addresses"/> for this company.
        /// </summary>
        public Addresses Addresses { get; set; }

        /// <summary>
        /// Gets or sets a collection of <see cref="People"/> who are employees for this company.
        /// </summary>
        public People Employees { get; set; }

        /// <summary>
        /// Gets or sets a collection of <see cref="People"/> who are customers of this company.
        /// </summary>
        public People Customers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of Company in the system.
        /// </summary>
        public Company()
        {
            EmailAddresses = new Emails();
            Numbers = new PhoneNumbers();
            Addresses = new Addresses();
            Employees = new People();
            Customers = new People();
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if (string.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name cannot be null or empty.", new[] { "Name" });
        }

        #endregion
    }
}
