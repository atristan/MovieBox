#region Includes

// .NET Libraries
using System.Configuration;

#endregion

namespace Utilities.Configuration
{
    /// <summary>
    /// Represents a configuration section group in the system.
    /// </summary>
    public class ConfigSection
        : ConfigurationSection
    {
        #region Properties

        /// <summary>
        /// Gets the collection of keys and values from the RingCentral settings custom section.
        /// </summary>
        [ConfigurationProperty("CustomSettings", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ConfigElementCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public ConfigElementCollection App => (ConfigElementCollection)base["CustomSettings"];

        #endregion
    }
}
