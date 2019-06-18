#region Includes

// .NET Libraries
using System.Data.Entity.ModelConfiguration;
using System.Runtime.InteropServices;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Configures the behavior for a movie in the model and the database.
    /// </summary>
    public class MovieConfiguration
        : EntityTypeConfiguration<Movie>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of PhoneNumberConfiguration in the system.
        /// </summary>
        public MovieConfiguration()
        {
            Property(x => x.Name).IsRequired().HasColumnName("Name");
            Property(x => x.GenreType).IsRequired().HasColumnName("TypeGenre");
            Property(x => x.TrackingId).IsRequired().HasColumnName("TrackingId");
            Property(x => x.RatePerDay).IsRequired().HasColumnName("RatePerDay");

            Property(x => x.ReleaseDate).HasColumnName("ReleaseDate");
        }

        #endregion
    }
}
