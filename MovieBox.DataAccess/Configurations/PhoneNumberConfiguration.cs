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
    /// Configures the behavior for a phone number in the model and the database.
    /// </summary>
    public class PhoneNumberConfiguration
        : EntityTypeConfiguration<PhoneNumber>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of PhoneNumberConfiguration in the system.
        /// </summary>
        public PhoneNumberConfiguration()
        {
            Property(x => x.EntityIdx).IsRequired().HasColumnName("EntityIdx");
            Property(x => x.AreaCode).IsRequired().HasColumnName("AreaCode");
            Property(x => x.Prefix).IsRequired().HasColumnName("Prefix");
            Property(x => x.LineNumber).IsRequired().HasColumnName("LineNumber");
            Property(x => x.CountryCodeType).IsRequired().HasColumnName("TypeCountryCode");
            Property(x => x.Ordinality).IsRequired().HasColumnName("TypeOrdinality");

            Property(x => x.Extension).HasColumnName("Extension");
            Property(x => x.PhoneType).HasColumnName("TypePhone");
        }

        #endregion
    }
}
