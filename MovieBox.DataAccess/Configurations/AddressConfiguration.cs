#region Includes

// .NET Libraries
using System.Data.Entity.ModelConfiguration;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    public class AddressConfiguration
        : EntityTypeConfiguration<Address>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of CustomerConfiguration in the system.
        /// </summary>
        public AddressConfiguration()
        {
            Property(x => x.EntityIdx).IsRequired().HasColumnName("EntityIdx");
            Property(x => x.ZipCode).IsRequired().HasColumnName("ZipCode");
            Property(x => x.Street1).IsRequired().HasColumnName("Street1");
            Property(x => x.City).IsRequired().HasColumnName("City");
            Property(x => x.Country).IsRequired().HasColumnName("Country");
            Property(x => x.StateOrProvince).IsRequired().HasColumnName("StateProvince");

            Property(x => x.Zip4).HasColumnName("Zip4");
            Property(x => x.Street2).HasColumnName("Street2");
            Property(x => x.Street3).HasColumnName("Street3");
            Property(x => x.County).HasColumnName("County");
        }

        #endregion
    }
}
