namespace Infrastructure
{
    /// <summary>
    /// Determines the usage type.
    /// </summary>
    public enum TypeUsage
    {
        /// <summary>
        /// Indicates usage type is not specified.
        /// </summary>
        None = -1,

        /// <summary>
        /// Indicates usage type is personal.
        /// </summary>
        Personal = 1,

        /// <summary>
        /// Indicates usage type is business.
        /// </summary>
        Business = 3,

        /// <summary>
        /// Indicates usage type is emergency.
        /// </summary>
        Emergency = 4,
    }
}
