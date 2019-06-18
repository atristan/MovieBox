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
    /// Configures the behavior for a rental in the model and the database.
    /// </summary>
    public class RentalConfiguration
        : EntityTypeConfiguration<Rental>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of PhoneNumberConfiguration in the system.
        /// </summary>
        public RentalConfiguration()
        {
            Property(x => x.EntityIdx).IsRequired().HasColumnName("EntityIdx");
            Property(x => x.TrackingId).IsRequired().HasColumnName("TrackingId");

            Property(x => x.IsDamaged).HasColumnName("IsDamaged");
            Property(x => x.DateRented).HasColumnName("DateRented");
            Property(x => x.DateReturned).HasColumnName("DateReturned");
        }

        #endregion
    }
}
