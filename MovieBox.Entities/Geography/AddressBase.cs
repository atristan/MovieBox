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
        : EntityBase, IAddress
    {
        #region IAddress Members

        /// <inheritdoc />
        [Required]
        public int ZipCode { get; set; }

        /// <inheritdoc />
        public int Zip4 { get; set; }

        /// <inheritdoc />
        [Required]
        public string Street1 { get; set; }

        /// <inheritdoc />
        public string Street2 { get; set; }

        /// <inheritdoc />
        public string Street3 { get; set; }

        /// <inheritdoc />
        [Required]
        public string City { get; set; }

        #endregion

        #region ICountry Members

        

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
