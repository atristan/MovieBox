#region Includes

// .NET Libraries
using System.ComponentModel;
using System.Configuration;

#endregion

namespace Utilities.Email
{
    /// <summary>
    /// Represents a collection of email elements in a system.
    /// </summary>
    public class EmailConfigCollection
        : ConfigurationElementCollection
    {
        #region Fields

        internal const string ATTRNM = "setting";

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value of the element at the specified index.
        /// </summary>
        /// <param name="index">The index location.</param>
        public EmailConfigElement this[int index]
        {
            get { return (EmailConfigElement)BaseGet(index); }
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
        new public EmailConfigElement this[string name] => (EmailConfigElement)BaseGet(name);

        /// <summary>
        /// Gets the element and all child elements.
        /// </summary>
        public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMap;

        /// <summary>
        /// Gets the attribute name for the element.
        /// </summary>
        protected override string ElementName => ATTRNM;

        public override bool IsReadOnly()
        {
            return false;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of ConfigCollection in the system.
        /// </summary>
        public EmailConfigCollection() { }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a configuration element to the collection.
        /// </summary>
        /// <param name="element">The element to add.</param>
        public void Add(EmailConfigElement element)
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
        /// <param name="index">The index of the element.</param>
        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>
        /// Removes element at the specified name location.
        /// </summary>
        /// <param name="name">The name of the element.</param>
        public void Remove(string name)
        {
            BaseRemove(name);
        }

        /// <summary>
        /// Determines whether element name is truly an element name.
        /// </summary>
        /// <param name="elementName">The name to check for.</param>
        /// <returns><c>true</c> if it is, otherwise <c>false</c>.</returns>
        protected override bool IsElementName(string elementName)
        {
            return elementName.Equals(ATTRNM, System.StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Returns the index of the element's index.
        /// </summary>
        /// <param name="element">The element to get the index of.</param>
        /// <returns>The index of the specified element.</returns>
        public int IndexOf(EmailConfigElement element)
        {
            return BaseIndexOf(element);
        }

        /// <summary>
        /// Creates a new email config element.
        /// </summary>
        /// <returns>A new email configuration element.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new EmailConfigElement();
        }

        /// <summary>
        /// Gets an element key from the EmailConfig configuration element.
        /// </summary>
        /// <param name="element">The configuration element.</param>
        /// <returns>The key for the element.</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((EmailConfigElement)element).Key;
        }

        #endregion
    }
}
