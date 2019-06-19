#region Includes

// .NET Libraries
using System.ComponentModel.DataAnnotations;

#endregion

namespace Infrastructure
{
    /// <summary>
    /// Determines the part or component of a phone number.
    /// </summary>
    public enum TypePhoneNumberComponent
    {
        /// <summary>
        /// Indicates no component was specified.
        /// </summary>
        None = -1,

        /// <summary>
        /// Indicates country code.
        /// </summary>
        CountryCode = 1,

        /// <summary>
        /// Indicates area code.
        /// </summary>
        AreaCode = 2,

        /// <summary>
        /// Indicates prefix.
        /// </summary>
        Prefix = 3,

        /// <summary>
        /// Indicates line number.
        /// </summary>
        LineNumber = 4,

        /// <summary>
        /// Indicates extension.
        /// </summary>
        Extension = 5
    }
}
