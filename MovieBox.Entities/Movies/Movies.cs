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
    /// Represents a collection of movies in the system.
    /// </summary>
    public class Movies
        : CollectionBase<Movie>
    {
        #region Constructors

        /// <inheritdoc />
        public Movies() { }

        /// <inheritdoc />
        public Movies(IList<Movie> initList)
            : base(initList) { }

        /// <inheritdoc />
        public Movies(CollectionBase<Movie> initList)
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
