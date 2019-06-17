#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// PRIS Libraries
using Infrastructure;
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents the base entity class with providers for ownership and date tracking.
    /// </summary>
    public class EntityBase
        : DomainEntity<int>, ITrackDate, IHasOwner
    {
        #region Methods

        /// <summary>
        /// Validates this object. It validates dependencies between properties and also calls Validate on child collections;
        /// </summary>
        /// <param name="validationContext">The object context to validate.</param>
        /// <returns>A IEnumerable of ValidationResult.  The IEnumerable is emtpy when the object is in a valid state, otherwise null.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });
        }

        #endregion

        #region ITrackDate Members

        /// <inheritdoc />
        public DateTime DateCreated { get; set; }

        /// <inheritdoc />
        public DateTime DateModified { get; set; }

        #endregion

        #region IHasOwner Members

        /// <inheritdoc />
        public int OwnerIdx { get; set; }

        /// <inheritdoc />
        public string OwnerUserId { get; set; }

        #endregion

    }
}
