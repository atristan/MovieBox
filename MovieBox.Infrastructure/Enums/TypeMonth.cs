#region Includes

// .NET Libraries
using System.ComponentModel;

#endregion

namespace Utilities
{
    /// <summary>
    /// Determines the month type in a calendar year.
    /// </summary>
    public enum TypeMonth
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        None = -1,

        /// <summary>
        /// Indicates month is January.
        /// </summary>
        [DefaultValue("01")]
        [Description("Jan")]
        January = 1,

        /// <summary>
        /// Indicates month is February.
        /// </summary>
        [DefaultValue("02")]
        [Description("Feb")]
        February = 2,

        /// <summary>
        /// Indicates month is March.
        /// </summary>
        [DefaultValue("03")]
        [Description("Mar")]
        March = 3,

        /// <summary>
        /// Indicates month is April.
        /// </summary>
        [DefaultValue("04")]
        [Description("Apr")]
        April = 4,

        /// <summary>
        /// Indicates month is May.
        /// </summary>
        [DefaultValue("05")]
        [Description("May")]
        May = 5,

        /// <summary>
        /// Indicates month is June.
        /// </summary>
        [DefaultValue("06")]
        [Description("Jun")]
        June = 6,

        /// <summary>
        /// Indicates month is July.
        /// </summary>
        [DefaultValue("07")]
        [Description("Jul")]
        July = 7,

        /// <summary>
        /// Indicates month is August.
        /// </summary>
        [DefaultValue("08")]
        [Description("Aug")]
        August = 8,

        /// <summary>
        /// Indicates month is September.
        /// </summary>
        [DefaultValue("09")]
        [Description("Sep")]
        September = 9,

        /// <summary>
        /// Indicates month is October.
        /// </summary>
        [DefaultValue("10")]
        [Description("Oct")]
        October = 10,

        /// <summary>
        /// Indicates month is November.
        /// </summary>
        [DefaultValue("11")]
        [Description("Nov")]
        November = 11,

        /// <summary>
        /// Indicates month is December.
        /// </summary>
        [DefaultValue("12")]
        [Description("Dec")]
        December = 12

    }
}