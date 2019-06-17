#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;

#endregion

namespace Utilities.Email
{
    /// <summary>
    /// Represents a single configuration element from the config file in the system.
    /// </summary>
    public class EmailConfigElement
        : ConfigurationElement
    {
        #region Properties

        /// <summary>
        /// Gets or sets the key from the custom settings.
        /// </summary>
        [ConfigurationProperty("key", DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Key
        {
            get => (string)this["key"];
            set => this["key"] = value;
        }

        /// <summary>
        /// Gets or sets the value from the custom settings.
        /// </summary>
        [ConfigurationProperty("value", DefaultValue = "", IsRequired = true, IsKey = false)]
        public string Value
        {
            get => (string)this["value"];
            set => this["value"] = value;
        }

        #endregion
    }
}
