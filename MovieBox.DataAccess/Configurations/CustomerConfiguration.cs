#region Includes

// .NET Libraries
using System.Data.Entity.ModelConfiguration;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Configures the behavior for a customer in the model and the database.
    /// </summary>
    public class CustomerConfiguration
        : EntityTypeConfiguration<Customer>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of CustomerConfiguration in the system.
        /// </summary>
        public CustomerConfiguration()
        {
            Property(x => x.FirstName).IsRequired().HasColumnName("FirstName");
            Property(x => x.LastName).IsRequired().HasColumnName("LastName");
            Property(x => x.CustomerId).IsRequired().HasColumnName("PersonIdx");

            Property(x => x.DateOfBirth).HasColumnName("DateOfBirth");
            Property(x => x.MemberStartDate).HasColumnName("MemberStartDate");
            Property(x => x.CustomerId).HasColumnName("CustomerIdx");
            Property(x => x.MiddleName).HasColumnName("MiddleName");
            Property(x => x.Suffix).HasColumnName("Suffix");
            Property(x => x.PersonTitleType).HasColumnName("TypePersonTitle");
        }

        #endregion
    }
}
