#region Includes

// .NET Libraries
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// MovieBox Libraries
using Infrastructure;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents the base address components.
    /// </summary>
    public abstract class AddressBase
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        [Required]
        public int ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the last four digits of a zip code.
        /// </summary>
        public int Zip4 { get; set; }

        /// <summary>
        /// Gets or sets the primary address locator.
        /// </summary>
        [Required]
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or sets a second address locator.
        /// </summary>
        public string Street2 { get; set; }

        /// <summary>
        /// Gets or sets a third address locator.
        /// </summary>
        public string Street3 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [Required]
        public string City { get; set; }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if (ZipCode == 0)
                yield return new ValidationResult("Zip code cannot be null or empty.", new[] { "ZipCode" });

            if (string.IsNullOrEmpty(Street1))
                yield return new ValidationResult("Street1 cannot be null or empty.", new[] { "Street1" });

            if(string.IsNullOrEmpty(City))
                yield return new ValidationResult("City cannot be null or empty.", new []{ "City" });
        }

        #endregion
    }
}
