namespace Infrastructure
{
    /// <summary>
    /// Determines what address component being worked with.
    /// </summary>
    public enum TypeAddressComponent
    {
        /// <summary>
        /// Indicates no address component was selected.
        /// </summary>
        None = -1,

        /// <summary>
        /// Indicates component is Street1.
        /// </summary>
        Street1 = 1,

        /// <summary>
        /// Indicates component is Street2.
        /// </summary>
        Street2 = 2,

        /// <summary>
        /// Indicates component is Street3.
        /// </summary>
        Street3 = 3,

        /// <summary>
        /// Indicates component is City.
        /// </summary>
        City = 4,

        /// <summary>
        /// Indicates component is County.
        /// </summary>
        County = 5,

        /// <summary>
        /// Indicates component is Country.
        /// </summary>
        Country = 6,

        /// <summary>
        /// Indicates component is Zip Code.
        /// </summary>
        ZipCode = 7,

        /// <summary>
        /// Indicates component is Zip 4.
        /// </summary>
        Zip4 = 8
    }
}
