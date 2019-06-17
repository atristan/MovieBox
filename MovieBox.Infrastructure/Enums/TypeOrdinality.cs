namespace Infrastructure.Enums
{
    /// <summary>
    /// Determines the type of position in an ordered series.
    /// </summary>
    public enum TypeOrdinality
    {
        /// <summary>
        /// Indicates no ordinality type set.
        /// </summary>
        None = -1,

        /// <summary>
        /// Indicates ordinality is primary or first.
        /// </summary>
        Primary = 1,

        /// <summary>
        /// Indicates ordinality is secondary or second.
        /// </summary>
        Secondary = 2,

        /// <summary>
        /// Indicates ordinality is tertiary or third.
        /// </summary>
        Tertiary = 3,

        /// <summary>
        /// Indicates ordinality is quaternary or fourth.
        /// </summary>
        Quaternary = 4,
    }
}
