#region Includes

// .NET Libraries
using System.Data.Entity;
using MovieBox.DataAccess;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Initializes the MovieBoxContext.
    /// </summary>
    public static class MovieBoxContextInitializer
    {
        /// <summary>
        /// Sets the IDatabaseInitializer for the application.
        /// </summary>
        /// <param name="dropDbIfModelChanges">
        /// When <c>true</c>, uses the <see cref="CreateDbIfModelChanges"/> to recreate the database when necessary,
        /// otherwise the db initialization is disabled by passing null to the SetInitializer method.
        /// </param>
        public static void Init(bool dropDbIfModelChanges)
        {
            if (dropDbIfModelChanges)
            {
                Database.SetInitializer(new CreateDbIfModelChanges());
                using (MovieBoxContext context = new MovieBoxContext())
                    context.Database.Initialize(false);
            }
            else
                Database.SetInitializer<MovieBoxContext>(null);
        }
    }
}
