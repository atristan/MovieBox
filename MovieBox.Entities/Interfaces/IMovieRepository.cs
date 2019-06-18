#region Includes

// .NET Libraries
using System.Collections.Generic;

// MovieBox Libraries
using Infrastructure.Interfaces;

#endregion

namespace Entities
{
    /// <summary>
    /// Defines various methods available to work with tje <see cref="Movie"/> repository in the system.
    /// </summary>
    public interface IMovieRepository
        : IRepository<Movie, int>
    {
        /// <summary>
        /// Finds a movie by its unique ID in the system.
        /// </summary>
        /// <param name="id">The unique ID of the movie in the system.</param>
        /// <returns>A single instance of <see cref="Movie"/> from the repository, otherwise returns null.</returns>
        Movie FindById(int id);

        /// <summary>
        /// Finds all instances of movie with the specified name.
        /// </summary>
        /// <param name="key">The name to search for.</param>
        /// <returns>A collection of instances with the name specified.</returns>
        IEnumerable<Movie> FindBy(string key);

        /// <summary>
        /// Deletes an instance of <see cref="Movie"/> from the repository.
        /// </summary>
        /// <param name="id">The ID of the instance to delete.</param>
        void DeleteById(int id);

        /// <summary>
        /// Saves an instance of <see cref="Movie"/> to the repository.
        /// </summary>
        /// <param name="instance"></param>
        void Save(Movie instance);
    }
}
