#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

// PRIS Libraries
using Infrastructure.Enums;

#endregion

namespace Entities
{
    /// <summary>
    /// Represents a movie in the system.
    /// </summary>
    public class Movie
        : EntityBase
    {
        #region Properties

        /// <summary>
        /// Gets or sets the tracking id for the movie.
        /// </summary>
        [Required]
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or sets the release date of the movie.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the rate of the movie per day.
        /// </summary>
        [Required]
        public double RatePerDay { get; set; }

        /// <summary>
        /// Gets or sets the name of the movie.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the genre of the movie.
        /// </summary>
        [Required]
        public TypeGenre GenreType { get; set; }

        /// <summary>
        /// Gets or sets a collection of people who starred in the movie.
        /// </summary>
        public People Actors { get; set; }

        /// <summary>
        /// Gets or sets a collection of people who directed the movie.
        /// </summary>
        public People Directors { get; set; }

        /// <summary>
        /// Gets or sets a collection of people who produced the movie.
        /// </summary>
        public People Producers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of Movie in the system.
        /// </summary>
        public Movie()
        {
            GenreType = TypeGenre.None;
            Actors = new People();
            Directors = new People();
            Producers = new People();
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id < 1)
                yield return new ValidationResult("Id supplied is not valid.", new[] { "Id" });

            if (RatePerDay < 1)
                yield return new ValidationResult("Rate supplied is not valid.", new[] { "RatePerDay" });

            if (string.IsNullOrEmpty(TrackingId))
                yield return new ValidationResult("Tracking Id cannot be null or empty", new []{ "TrackingId" });

            if (string.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name cannot be null or empty.", new[] { "Name" });

            if (GenreType == TypeGenre.None)
                yield return new ValidationResult("Genre cannot be null or empty.", new[] { "GenreType" });
        }

        #endregion
    }
}
