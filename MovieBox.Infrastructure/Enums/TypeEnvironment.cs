#region Includes

// .NET Libraries
using System.ComponentModel;

#endregion

namespace Utilities
{
    /// <summary>
    /// Determines the execution environment.
    /// </summary>
    public enum TypeEnvironment
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        [Description("None Selected")]
        None = -1,

        /// <summary>
        /// Indicates development mode.
        /// </summary>
        [Description("Development")]
        DEV = 1,

        /// <summary>
        /// Indicates test mode.
        /// </summary>
        [Description("Test")]
        TST = 2,

        /// <summary>
        /// Indicates production mode.
        /// </summary>
        [Description("Production")]
        PRD = 3,

        /// <summary>
        /// Indicates QA mode.
        /// </summary>
        [Description("Quality Assurance Testing")]
        QAT = 4
    }
}