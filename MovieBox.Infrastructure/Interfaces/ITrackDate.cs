#region Includes

// .NET Libraries
using System;

#endregion

namespace Infrastructure.Interfaces
{
    /// <summary>
    /// Defines an interface for objects whose creation and modification dates need to be tracked.
    /// </summary>
    public interface ITrackDate
    {
        /// <summary>
        /// Gets or sets the date and time the object was created.
        /// </summary>
        DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was modified.
        /// </summary>
        DateTime DateModified { get; set; }
    }
}
