#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// PRIS Libraries
using Infrastructure;
using Infrastructure.Enums;
using MovieBox.Entities;

#endregion

namespace Entities
{
    public class Email
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID of the entity the email belongs to.
        /// </summary>
        public int EntityIdx { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the ordinal type of the email.
        /// </summary>
        public TypeOrdinality OrdinalType { get; set; }

        /// <summary>
        /// Gets or sets the usage type of the email address.
        /// </summary>
        public TypeUsage UsageType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of Email in the ssytem.
        /// </summary>
        public Email()
        {
            UsageType = TypeUsage.None;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if (string.IsNullOrEmpty(Address))
                yield return new ValidationResult("Email address cannot be null or empty.", new[] { "Address" });
        }

        #endregion
    }
}
