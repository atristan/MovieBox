#region Includes

// .NET Libraries
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// MovieBox Libraries
using Infrastructure.Enums;
using Utilities;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents a phone number in the system.
    /// </summary>
    public class PhoneNumber
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the entity ID the phone number belongs to.
        /// </summary>
        [Required]
        public int EntityIdx { get; set; }

        /// <summary>
        /// Gets or sets the area code for a number.
        /// </summary>
        [Required]
        public int AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the first three numbers after the area code of a number.
        /// </summary>
        [Required]
        public int Prefix { get; set; }

        /// <summary>
        /// Gets or sets the last four digits of a phone number.
        /// </summary>
        [Required]
        public int LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the extension (if any).
        /// </summary>
        public int Extension { get; set; }

        /// <summary>
        /// Gets or sets the phone type.
        /// </summary>
        public TypePhone PhoneType { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [Required]
        public TypeCountryCode CountryCodeType { get; set; }

        /// <summary>
        /// Gets or sets the ordinality of the phone number (i.e. primary, secondary, etc.).
        /// </summary>
        [Required]
        public TypeOrdinality Ordinality { get; set; }

        #endregion

        #region Constructors

        public PhoneNumber()
        {
            PhoneType = TypePhone.None;
            CountryCodeType = TypeCountryCode.None;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Converts a phone number to a string with the following format:
        ///     15122239876
        /// </summary>
        /// <returns>A string value representing the country code, the area code, and the number with no special characters.</returns>
        public override string ToString()
        {
            return $"{(int)CountryCodeType}{AreaCode}{Prefix}{LineNumber}";
        }

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Idx" });

            if (EntityIdx < 1)
                yield return new ValidationResult("Entity Id supplied is not valid.", new[] { "EntityIdx" });

            if (AreaCode == 0)
                yield return new ValidationResult("Area code cannot be null or empty.", new[] { "AreaCode" });

            if(Prefix == 0)
                yield return new ValidationResult("Prefix cannot be null or empty.", new [] { "Prefix" });

            if (LineNumber == 0)
                yield return new ValidationResult("Line number cannot be null or empty.", new[] { "LineNumber2" });

            if(CountryCodeType == TypeCountryCode.None)
                yield return new ValidationResult("Country code must be set.", new [] { "CountryCodeType" });

            if(Ordinality == TypeOrdinality.None)
                yield return new ValidationResult("Ordinality must be set.", new [] { "Ordinality" });
        }

        #endregion
    }
}
