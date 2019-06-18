#region Includes

// .NET Libraries
using System.Data.Entity;

#endregion

namespace DataAccess
{
    /// <summary>
    /// Initializes the MovieBoxContext.
    /// </summary>
    public static class MovieBoxContextInitializer
    {
        public static void Init(bool dropDbIfModelChanges)
        {
            if (dropDbIfModelChanges)
            {
                Database.SetInitializer();
            }
        }
    }
}
