namespace Infrastructure.Interfaces
{
    /// <summary>
    /// Defines an interface used to mark the owner of an object.
    /// </summary>
    public interface IHasOwner
    {
        /// <summary>
        /// Gets or sets the owner's unique ID in the system.
        /// </summary>
        int OwnerIdx { get; set; }

        /// <summary>
        /// Gets or sets the owner's user id in the system.
        /// </summary>
        string OwnerUserId { get; set; }
    }
}
