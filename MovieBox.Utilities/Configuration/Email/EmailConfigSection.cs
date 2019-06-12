#region Includes

// .NET Libraries
using System.ComponentModel;
using System.Configuration;

#endregion

namespace Utilities.Email
{
    /// <summary>
    /// Represents the email configuration section in a config file within a system.
    /// </summary>
    public class EmailConfigSection
        : ConfigurationSection
    {
        #region Fields

        internal const string _ele = "Section";

        #endregion

        #region Properties

        /// <summary>
        /// Gets a handle for the settings collection in the email section.
        /// </summary>
        [ConfigurationProperty(_ele, IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(EmailConfigCollection))]
        public EmailConfigCollection Settings => (EmailConfigCollection)this[_ele];

        #endregion
    }
}
