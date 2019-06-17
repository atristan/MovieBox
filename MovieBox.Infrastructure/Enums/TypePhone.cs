namespace Infrastructure.Enums
{
    /// <summary>
    /// Determines the type of phone.
    /// </summary>
    public enum TypePhone
    {
        /// <summary>
        /// Indicates no phone type selected.
        /// </summary>
        None = -1,

        /// <summary>
        /// Indicates phone type is a home number.
        /// </summary>
        Home = 2,

        /// <summary>
        /// Indicates phone type is a mobile number.
        /// </summary>
        Mobile = 3,

        /// <summary>
        /// Indicates phone type is a fax number.
        /// </summary>
        Fax = 4,
    }
}
