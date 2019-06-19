#region Includes

// .NET Libraries
using System.Collections.Generic;
using Infrastructure.Enums;

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
        /// <param name="trackingId">The tracking ID of the movie in the system.</param>
        /// <returns>A single instance of <see cref="Movie"/> from the repository, otherwise returns null.</returns>
        Movie FindByTrackingId(string trackingId);

        /// <summary>
        /// Finds all movies with the specified key in their movie title.
        /// </summary>
        /// <param name="key">Search key string.</param>
        /// <returns>A collection of movies when the search key is found, otherwise null.</returns>
        IEnumerable<Movie> FindAllByName(string key);

        /// <summary>
        /// Finds all movies by genre type.
        /// </summary>
        /// <param name="genreType"></param>
        /// <returns></returns>
        IEnumerable<Movie> FindAllByGenre(TypeGenre genreType);
    }
}
