namespace Entities
{
    public interface IAddress
    {
        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        int ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the last four digits of a zip code.
        /// </summary>
        int Zip4 { get; set; }

        /// <summary>
        /// Gets or sets the primary address locator.
        /// </summary>
        string Street1 { get; set; }

        /// <summary>
        /// Gets or sets a second address locator.
        /// </summary>
        string Street2 { get; set; }

        /// <summary>
        /// Gets or sets a third address locator.
        /// </summary>
        string Street3 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        string City { get; set; }
    }
}
