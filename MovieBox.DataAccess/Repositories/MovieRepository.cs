#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Linq;

// MovieBox Libraries
using Entities;
using Infrastructure.Enums;

#endregion

namespace DataAccess
{
    /// <summary>
    /// A concrete repository to work with movies in the system.
    /// </summary>
    public class MovieRepository
        : Repository<Movie>, IMovieRepository
    {
        #region IMovieRepository Members

        /// <inheritdoc />
        public Movie FindByTrackingId(string trackingId)
        {
            return DataContextFactory.GetDataContext().Set<Movie>().FirstOrDefault(x => x.TrackingId == trackingId);
        }

        /// <inheritdoc />
        public IEnumerable<Movie> FindAllByName(string key)
        {
            return DataContextFactory.GetDataContext().Set<Movie>().Where(x => x.Name.Contains(key));
        }

        /// <inheritdoc />
        public IEnumerable<Movie> FindAllByGenre(TypeGenre genreType)
        {
            return DataContextFactory.GetDataContext().Set<Movie>().Where(x => x.GenreType == genreType);
        }

        #endregion
    }
}
