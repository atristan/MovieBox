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
    /// Configures the behavior for a company in the model and the database.
    /// </summary>
    public class CompanyConfiguration
        : EntityTypeConfiguration<Company>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of CompanyConfiguration in the system.
        /// </summary>
        public CompanyConfiguration()
        {
            Property(x => x.Name).IsRequired().HasColumnName("Name");
        }

        #endregion
    }
}
