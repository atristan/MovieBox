using System.ComponentModel;

namespace Infrastructure
{
    /// <summary>
    /// Determines a person's title.
    /// </summary>
    public enum TypePersonTitle
    {
        /// <summary>
        /// Indicates no title provided.
        /// </summary>
        None = -1,

        /// <summary>
        /// Indicates title is Mr.
        /// </summary>
        [DefaultValue("Mr.")]
        Mr = 1,

        /// <summary>
        /// Indicates title is Mrs.
        /// </summary>
        [DefaultValue("Mrs.")]
        Mrs = 2,

        /// <summary>
        /// Indicates title is Ms.
        /// </summary>
        [DefaultValue("Ms.")]
        Ms = 3,

        /// <summary>
        /// Indicates title is Dr.
        /// </summary>
        [DefaultValue("Dr.")]
        Doctor = 4,

        /// <summary>
        /// Indicates title is Hon.
        /// </summary>
        [DefaultValue("Hon.")]
        Honorable = 5,
    }
}