#region Includes

// .NET Libraries
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace Infrastructure
{
    /// <summary>
    /// Base class for all entities in the system.
    /// </summary>
    /// <typeparam name="T">The type of the key for the entity.</typeparam>
    public abstract class DomainEntity<T>
        : IValidatableObject
    {
        #region Member Properties

        /// <summary>
        /// Gets or sets the unique id of the entity in the data store.
        /// </summary>
        public T Id { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Checks if the current domain entity has an identity.
        /// </summary>
        /// <returns></returns>
        public bool IsTransient() { return Id.Equals(default(T)); }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current; otherwise <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is DomainEntity<T>))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            var item = (DomainEntity<T>)obj;

            if (item.IsTransient() || IsTransient())
                return false;

            return item.Id.Equals(Id);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current <see cref="T:System.Object" /></returns>
        public override int GetHashCode()
        {
            if (!IsTransient())
                return Id.GetHashCode() ^ 31;

            return base.GetHashCode();
        }

        #endregion

        #region Operator Overloads

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The left instance to compare</param>
        /// <param name="right">The right instance to compare.</param>
        /// <returns><c>true</c> when the objects are the same, <c>false</c> otherwise.</returns>
        public static bool operator == (DomainEntity<T> left, DomainEntity<T> right)
        {
            if (Equals(left, null))
                return Equals(right, null);

            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The left instance to compare.</param>
        /// <param name="right">The right instance to compare.</param>
        /// <returns><c>falsel</c> when the objects are the same, <c>true</c> otherwise.</returns>
        public static bool operator !=(DomainEntity<T> left, DomainEntity<T> right)
        {
            return !(left == right);
        }

        #endregion

        #region Validation

        /// <summary>
        /// Determines whether this object is valid or not.
        /// </summary>
        /// <param name="validationContext">Describes the context in which a validation check is performed.</param>
        /// <returns>A IEnumerable of ValidationResult.  The IEnumerable is empty when the object is in a valid state.</returns>
        public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);

        #region IValidatableObject Members

        /// <summary>
        /// Determines whether this object is valid or not.
        /// </summary>
        /// <returns>A IEnumerable of ValidationResult.  The IEnuemrable is empty when the object is in a valid state.</returns>
        public IEnumerable<ValidationResult> Validate()
        {
            var validationErrors = new List<ValidationResult>();
            var ctx = new ValidationContext(this, null, null);
            Validator.TryValidateObject(this, ctx, validationErrors, true);
            return validationErrors;
        }

        #endregion

        #endregion
    }
}
