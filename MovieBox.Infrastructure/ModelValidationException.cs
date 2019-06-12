#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace Infrastructure
{
    public class ModelValidationException
        : Exception
    {
        #region Member Fields

        #endregion

        #region Member Properties

        /// <summary>
        /// A collection of validation errors for the entity that failed validation.
        /// </summary>
        public IEnumerable<ValidationResult> ValidationErrors { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the ModelValidationException class.
        /// </summary>
        public ModelValidationException() { }

        /// <summary>
        /// Initializes a new instance of the ModelValidationException class.
        /// </summary>
        /// <param name="message">The developer defined message.</param>
        public ModelValidationException(string message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of the ModelValidationException class.
        /// </summary>
        /// <param name="message">The developer defined message.</param>
        /// <param name="innerEx">The inner exception from the error.</param>
        public ModelValidationException(string message, Exception innerEx)
            : base(message, innerEx) { }

        /// <summary>
        /// Initializes a new instance of the ModelValidationException class.
        /// </summary>
        /// <param name="message">The developer defined message.</param>
        /// <param name="innerEx">The inner exception from error.</param>
        /// <param name="validationErrors">A IEnumerable of validation errors.</param>
        public ModelValidationException(string message
                                      , Exception innerEx
                                      , IEnumerable<ValidationResult> validationErrors)
            : base(message, innerEx)
        {
            ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the ModelValidationException class.
        /// </summary>
        /// <param name="message">The developer defined message.</param>
        /// <param name="validationErrors">A IEnumerable of validation errors.</param>
        public ModelValidationException(string message, IEnumerable<ValidationResult> validationErrors)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of ModelValidationException class.
        /// </summary>
        /// <param name="info">Serialized instance of object.</param>
        /// <param name="context">The streamed context.</param>
        protected ModelValidationException(System.Runtime.Serialization.SerializationInfo info
                                      , System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        #endregion
    }
}
