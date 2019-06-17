#region Includes

// .NET Libraries
using System.ComponentModel;
using System.Configuration;

#endregion

namespace Utilities.Configuration
{
    /// <summary>
    /// Represents a collection of configuration elements in the system.
    /// </summary>
    public class ConfigElementCollection
        : ConfigurationElementCollection
    {
        #region Properties

        /// <summary>
        /// Gets or sets the value of the element at the specified index.
        /// </summary>
        /// <param name="index">The index location.</param>
        public ConfigElement this[int index]
        {
            get => (ConfigElement)BaseGet(index);
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);
                BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Gets the element at the specified name.
        /// </summary>
        /// <param name="name">The element name to get the value for.</param>
        /// <returns>Returns the element with the specified name.</returns>
        public new ConfigElement this[string name] => (ConfigElement)BaseGet(name);

        /// <summary>
        /// Gets the element and all child elements.
        /// </summary>
        public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.AddRemoveClearMap;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of ConfigCollection in the system.
        /// </summary>
        public ConfigElementCollection() { }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a configuration element to the collection.
        /// </summary>
        /// <param name="element">The element to add.</param>
        public void Add(ConfigElement element)
        {
            BaseAdd(element);
        }

        /// <summary>
        /// Adds an element to the collection.
        /// </summary>
        /// <param name="element">The element to add.</param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            base.BaseAdd(element, false);
        }

        /// <summary>
        /// Removes all configuration elements from the collection.
        /// </summary>
        public void Clear()
        {
            BaseClear();
        }

        /// <summary>
        /// Removes element at the specified location.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>
        /// Removes element at the specified name location.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            BaseRemove(name);
        }

        /// <summary>
        /// Returns the index of the element's index.
        /// </summary>
        /// <param name="element">The element to get the index of.</param>
        /// <returns>The index of the specified element.</returns>
        public int IndexOf(ConfigElement element)
        {
            return BaseIndexOf(element);
        }

        /// <summary>
        /// Creates a new email config element.
        /// </summary>
        /// <returns>An EmailConfig object.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigElement();
        }

        /// <summary>
        /// Gets an element key from the EmailConfig configuration element.
        /// </summary>
        /// <param name="element">The configuration element.</param>
        /// <returns>The key for the element.</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConfigElement)element).Key;
        }

        #endregion
    }
}
