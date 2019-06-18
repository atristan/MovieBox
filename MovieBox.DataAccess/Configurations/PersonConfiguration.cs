#region Includes

// .NET Libraries
using System.Data.Entity.ModelConfiguration;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Configures the behavior for a person in the model and the database.
    /// </summary>
    public class PersonConfiguration
        : EntityTypeConfiguration<Person>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of CustomerConfiguration in the system.
        /// </summary>
        public PersonConfiguration()
        {
            Property(x => x.FirstName).IsRequired().HasColumnName("FirstName");
            Property(x => x.LastName).IsRequired().HasColumnName("LastName");

            Property(x => x.DateOfBirth).HasColumnName("DateOfBirth");
            Property(x => x.MiddleName).HasColumnName("MiddleName");
            Property(x => x.Suffix).HasColumnName("Suffix");
            Property(x => x.PersonTitleType).HasColumnName("TypePersonTitle");
        }

        #endregion
    }
}
