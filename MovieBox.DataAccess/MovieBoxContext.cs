#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using DataAccess;

// MovieBox Libraries
using Entities;
using Infrastructure;
using Infrastructure.Interfaces;

#endregion



namespace MovieBox.DataAccess
{
    /// <summary>
    /// The main DbContext to work with data in the database.
    /// </summary>
    public class MovieBoxContext
        : DbContext
    {
        #region Properties

        /// <summary>
        /// Provides access to the collection of customers in the repository.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the MovieBoxContext.
        /// </summary>
        public MovieBoxContext()
            : base("MovieBoxContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Hooks into the Save process to geta last-minute chance to look at the entities and change them.
        /// </summary>
        /// <returns>The number of affected rows.</returns>
        public override int SaveChanges()
        {
            var orphanedObjects = ChangeTracker.Entries().Where(
                                        e => (e.State == EntityState.Modified || e.State == EntityState.Added) &&
                                             e.Entity is IHasOwner &&
                                                e.Reference("Owner").CurrentValue == null);

            foreach (var orphanedObject in orphanedObjects)
                orphanedObject.State = EntityState.Deleted;

            try
            {
                var modified = ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

                foreach (var item in modified)
                {
                    var changedOrAddedItem = item.Entity as ITrackDate;

                    if (changedOrAddedItem != null)
                    {
                        if (item.State == EntityState.Added)
                            changedOrAddedItem.DateCreated = DateTime.Now;

                        changedOrAddedItem.DateModified = DateTime.Now;
                    }
                }

                return base.SaveChanges();
            }
            catch (DbEntityValidationException entityException)
            {
                IEnumerable<DbEntityValidationResult> errors = entityException.EntityValidationErrors;
                StringBuilder result = new StringBuilder();
                List<ValidationResult> allErrors = new List<ValidationResult>();

                foreach (DbEntityValidationResult error in errors)
                {
                    foreach (DbValidationError validationError in error.ValidationErrors)
                    {
                        result.AppendFormat(
                            $"\r\n Entity of type {error.Entry.Entity.GetType().ToString()} has validation error '{validationError.ErrorMessage}' for property {validationError.PropertyName}.\r\n");

                        var domainEntity = error.Entry.Entity as DomainEntity<int>;

                        if (domainEntity != null)
                            result.Append(domainEntity.IsTransient()
                                ? $"  This entity was added in this session.\r\n"
                                : $"  Th Id of the entity is {domainEntity.Id}.\r\n");

                        allErrors.Add(new ValidationResult(validationError.ErrorMessage, new [] { validationError.PropertyName }));
                    }
                }

                throw new ModelValidationException(result.ToString(), entityException, allErrors);
            }
        }

        /// <summary>
        /// Configures the EF context.
        /// </summary>
        /// <param name="modelBuilder">The modle builder that needs to be configured.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
        }

        #endregion
    }
}
