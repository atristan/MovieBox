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
    public class Address
        : EntityBase
    {
        #region IAddress Members

        /// <summary>
        /// Gets or sets the ID of the entity this address belongs to.
        /// </summary>
        [Required]
        public int EntityIdx { get; set; }

        /// <summary>
        /// Gets or sets the zip code for an address.
        /// </summary>
        [Required]
        public int ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the last four of a zip code.
        /// </summary>
        public int Zip4 { get; set; }

        /// <summary>
        /// Gets or sets the primary street information.
        /// </summary>
        [Required]
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or sets the secondary street information.
        /// </summary>
        public string Street2 { get; set; }

        /// <summary>
        /// Gets or sets the tertiary street information.
        /// </summary>
        public string Street3 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the county (if any).
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state or province.
        /// </summary>
        [Required]
        public string StateOrProvince { get; set; }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if (EntityIdx < 1)
                yield return new ValidationResult("Entity Id supplied is not valid.", new[] { "EntityIdx" });

            if (ZipCode == 0)
                yield return new ValidationResult("Zip code cannot be null or empty.", new[] { "ZipCode" });

            if (string.IsNullOrEmpty(Street1))
                yield return new ValidationResult("Street1 cannot be null or empty.", new[] { "Street1" });

            if(string.IsNullOrEmpty(City))
                yield return new ValidationResult("City cannot be null or empty.", new[] { "City" });

            if (string.IsNullOrEmpty(Country))
                yield return new ValidationResult("Country cannot be null or empty", new[] { "Country" });

            if (string.IsNullOrEmpty(Country))
                yield return new ValidationResult("State or province cannot be null or empty", new[] { "StateOrProvince" });
        }

        #endregion
    }
}
