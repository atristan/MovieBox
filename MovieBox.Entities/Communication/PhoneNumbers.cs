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
    /// Represents a collection of phone numbers in the system.
    /// </summary>
    public class PhoneNumbers
        : CollectionBase<PhoneNumber>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumbers"/> class.
        /// </summary>
        public PhoneNumbers() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumbers"/> class.
        /// </summary>
        /// <param name="initList">Accepts an IList of Employer as the initial list.</param>
        public PhoneNumbers(IList<PhoneNumber> initList)
            : base(initList) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumbers"/> class.
        /// </summary>
        /// <param name="initList">Accepts a CollectionBase of Employer as the initial list.</param>
        public PhoneNumbers(CollectionBase<PhoneNumber> initList)
            : base(initList) { }

        #endregion

        #region Validation

        /// <summary>
        /// Validates the current collection by validating each individual item in the collection.
        /// </summary>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public IEnumerable<ValidationResult> Validate()
        {
            var errors = new List<ValidationResult>();
            foreach (var item in this)
                errors.AddRange(item.Validate());
            return errors;
        }

        #endregion
    }
}
