#region Includes

// .NET Libraries
using System.Configuration;

#endregion

namespace Utilities.Email
{
    public class EmailConfigService
    {
        #region Fields

        private EmailConfigSection _section;

        #endregion

        #region Properties

        /// <summary>
        /// Gets a handle for the email settings section.
        /// </summary>
        public EmailConfigSection Section => _section ?? (_section = ConfigurationManager.GetSection("EmailSection") as EmailConfigSection);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of EmailConfigService in the system.
        /// </summary>
        public EmailConfigService() { }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a setting value based on the setting being requested.
        /// </summary>
        /// <param name="setting">The setting to grab the value for.</param>
        /// <returns>String with the setting value.</returns>
        public string GetSetting(string setting)
        {
            return Section.Settings[setting] == null ? string.Empty : Section.Settings[setting].Value;
        }

        #endregion
    }
}
