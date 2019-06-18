#region Includes

// .NET Libraries
using System.Data.Entity.ModelConfiguration;

// MovieBox Libraries
using Entities;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Configures the behavior for an email in the model and the database.
    /// </summary>
    public class EmailConfiguration
        : EntityTypeConfiguration<Email>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of EmailConfiguration in the system.
        /// </summary>
        public EmailConfiguration()
        {
            Property(x => x.EntityIdx).IsRequired().HasColumnName("EntityIdx");
            Property(x => x.Address).IsRequired().HasColumnName("Address");
        }

        #endregion
    }
}
