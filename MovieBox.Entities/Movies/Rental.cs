#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents a US-based rental.
    /// </summary>
    public class Rental
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets a flag indicating whether or not rental is damaged.
        /// </summary>
        public bool IsDamaged { get; set; }

        /// <summary>
        /// Gets or sets the date rented.
        /// </summary>
        public DateTime? DateRented { get; set; }

        /// <summary>
        /// Gets or sets the date returned.
        /// </summary>
        public DateTime? DateReturned { get; set; }

        /// <summary>
        /// Gets or sets the rate per day of the rental.
        /// </summary>
        [Required]
        public double RatePerDay { get; set; }

        /// <summary>
        /// Gets or sets an alpha-numeric tracking id for the rental.
        /// </summary>
        [Required]
        public string TrackingId { get; set; }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if(RatePerDay < 1)
                yield return new ValidationResult("Rate per day cannot be 0.", new []{ "RatePerDay" });

            if (string.IsNullOrEmpty(TrackingId))
                yield return new ValidationResult("Tracking ID cannot be null or empty.", new[] { "TrackingId" });
        }

        #endregion
    }
}
