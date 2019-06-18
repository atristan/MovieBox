#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents a rental in the system.
    /// </summary>
    public class Rental
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the entity id who rented the movie or movies.
        /// </summary>
        [Required]
        public int EntityIdx { get; set; }

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
        /// Gets or sets an alpha-numeric tracking id for the rental.
        /// </summary>
        [Required]
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or sets a collection of <see cref="Movie"/> that were checked out with this rental.
        /// </summary>
        public Movies CheckedOut { get; set; }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if (EntityIdx < 1)
                yield return new ValidationResult("Entity id supplied is not valid.", new[] { "EntityIdx" });

            if (string.IsNullOrEmpty(TrackingId))
                yield return new ValidationResult("Tracking ID cannot be null or empty.", new[] { "TrackingId" });
        }

        /// <summary>
        /// Gets the rate per day for the rental.
        /// </summary>
        /// <returns>A double value indicating how much per day the rental is.</returns>
        public double GetRatePerDay()
        {
            double result = 0d;
            if (CheckedOut.Count > 0)
            {
                foreach (Movie movie in CheckedOut)
                    result += result + movie.RatePerDay;
            }

            return result;
        }

        public double? GetTotalRate()
        {
            if (DateReturned == null)
                return null;


        }

        #endregion
    }
}
