#region Includes

// .NET Libraries
using System.Configuration;

#endregion

namespace Utilities.Configuration
{
    /// <summary>
    /// Represents a configuration element in the system.
    /// </summary>
    public class ConfigElement
        : ConfigurationElement
    {
        #region Properties

        /// <summary>
        /// Gets or sets the key from the custom settings.
        /// </summary>
        [ConfigurationProperty("key", DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Key
        {
            get { return (string)this["key"]; }
            set { this["key"] = value; }
        }

        /// <summary>
        /// Gets or sets the value from the custom settings.
        /// </summary>
        [ConfigurationProperty("value", DefaultValue = "", IsRequired = true, IsKey = false)]
        public string Value
        {
            get { return (string)this["value"]; }
            set { this["value"] = value; }
        }

        #endregion
    }
}
