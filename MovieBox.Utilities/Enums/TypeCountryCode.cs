#region Includes

// .NET Libraries
using System.ComponentModel;

#endregion

namespace Utilities
{
    /// <summary>
    /// Determines the application mode.
    /// </summary>
    public enum TypeCountryCode
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        [Description("None Selected")]
        None = -1,

        /// <summary>
        /// Indicates development mode.
        /// </summary>
        [Description("United States")]
        US = 1,

        /// <summary>
        /// Indicates development mode.
        /// </summary>
        [Description("Mexico")]
        Mexico = 52,
    }
}
