#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// PRIS Libraries
using Infrastructure;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents a person in the system.
    /// </summary>
    public class Person
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the date of birth for the person.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the person's firts name.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the person's middle name or middle initial.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the person's last name.
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the person's suffix.
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the person's title.
        /// </summary>
        public TypePersonTitle PersonTitleType { get; set; }

        /// <summary>
        /// Gets or sets a collection of physical addresses associated with this person.
        /// </summary>
        public Addresses MailingAddresses { get; set; }

        /// <summary>
        /// Gets or sets a collection of phone numbers associated with this person.
        /// </summary>
        public PhoneNumbers Numbers { get; set; }

        /// <summary>
        /// Gets or sets a collection of email addresses associated with this person.
        /// </summary>
        public Emails EmailAddresses { get; set; }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if (string.IsNullOrEmpty(FirstName))
                yield return new ValidationResult("First name cannot be null or empty.", new[] { "FirstName" });

            if (string.IsNullOrEmpty(LastName))
                yield return new ValidationResult("Last name cannot be null or empty.", new[] { "LastName" });
        }

        #endregion
    }
}
