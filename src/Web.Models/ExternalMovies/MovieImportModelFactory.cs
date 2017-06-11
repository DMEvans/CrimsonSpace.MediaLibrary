//-----------------------------------------------------------------------
// <copyright file="MovieImportModelFactory.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using ExternalApi.TheMovieDB.Domain;
    using ExternalApi.TheMovieDB.Domain.Interfaces;
    using ExternalApi.TheMovieDB.Service.Helpers;
    using System.Collections.Generic;
    using System.Linq;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// Factory class for the creation of model classes for the movie import domain
    /// </summary>
    public class MovieImportModelFactory
    {
        #region Members

        /// <summary>
        /// The job names which qualify a crew member as being a director
        /// </summary>
        private IEnumerable<string> _directorJobNames = new List<string>
        {
            "Director",
            "Co-Director"
        };

        /// <summary>
        /// The genres
        /// </summary>
        private IEnumerable<GenreResult> _genres;

        /// <summary>
        /// The image helper
        /// </summary>
        private ImageUrlHelper _imageHelper;

        /// <summary>
        /// The producer job names
        /// </summary>
        private IEnumerable<string> _producerJobNames = new List<string>
        {
            "Producer",
            "Executive Producer"
        };

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="MovieImportModelFactory"/> class.
        /// </summary>
        /// <param name="imageHelper">The image helper.</param>
        public MovieImportModelFactory(ImageUrlHelper imageHelper)
        {
            _imageHelper = imageHelper;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public IEnumerable<GenreResult> Genres
        {
            set
            {
                _genres = value;
            }
        }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Creates a movie search result model from an external movie search result.
        /// </summary>
        /// <param name="source">The external movie search result.</param>
        /// <returns>Movie search result model</returns>
        public MovieSearchResultModel Create(MovieSearchResult source)
        {
            return new MovieSearchResultModel
            {
                TotalPages = source.TotalPages,
                TotalResults = source.TotalResults,
                Results = source.Results.Select(x => Create(x)).ToList()
            };
        }

        /// <summary>
        /// Creates a basic movie result model from an external basic movie result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Basic movie result model</returns>
        public BasicMovieResultModel Create(BasicMovieResult source)
        {
            return new BasicMovieResultModel
            {
                Genres = ParseMovieGenres(source.GenreIds),
                Id = source.Id,
                Overview = source.Overview,
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.ExtraSmall),
                ReleaseYear = source.ReleaseDate.GetValueOrDefault().Year,
                Title = source.Title
            };
        }

        /// <summary>
        /// Creates a model result with an ID and name property from a basic result object.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Named item model</returns>
        public NamedItemModel Create(IBasicObject source)
        {
            return new NamedItemModel
            {
                Id = source.Id,
                Name = source.Name
            };
        }

        /// <summary>
        /// Creates a basic collection result model from external basic collection result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Basic collection result model</returns>
        public BasicCollectionResultModel Create(BasicCollectionResult source)
        {
            if (source == null)
            {
                return null;
            }

            return new BasicCollectionResultModel
            {
                Id = source.Id,
                Name = source.Name,
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Small)
            };
        }

        /// <summary>
        /// Creates and extended collection result model from an external extended collection result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Extended collection result model</returns>
        public ExtendedCollectionResultModel Create(ExtendedCollectionResult source)
        {
            return new ExtendedCollectionResultModel
            {
                Overview = source.Overview,
                Parts = source.Parts.Select(x => Create(x)).OrderBy(x => x.ReleaseYear),
                Name = source.Name,
                BackdropImageUrl = FormalizeImagePath(source.BackdropPath, ImageTypes.Backdrop, ImageSizes.Medium),
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Small),
                PosterImageUrlOriginal = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Original),
                Genres = ParseMovieGenres(source.Parts?.SelectMany(x => x.GenreIds).Distinct().ToList())
            };
        }

        /// <summary>
        /// Creates an extended movie result model from an external extended movie result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Extended movie result model</returns>
        public ExtendedMovieResultModel Create(ExtendedMovieResult source)
        {
            return new ExtendedMovieResultModel
            {
                Collection = Create(source.Collection),
                HomePage = source.HomePage,
                Id = source.Id,
                ImdbId = source.ImdbId,
                Overview = source.Overview,
                ReleaseDate = source.ReleaseDate.GetValueOrDefault().ToShortDateString(),
                ReleaseYear = source.ReleaseDate.GetValueOrDefault().Year,
                Runtime = source.Runtime.ToString() + " minutes",
                Status = source.Status,
                Tagline = source.Tagline,
                Title = source.Title,
                Budget = "$" + source.Budget.ToString("N2"),
                Profit = "$" + (source.Revenue - source.Budget).ToString("N2"),
                Revenue = "$" + source.Revenue.ToString("N2"),
                BackdropImageUrl = FormalizeImagePath(source.BackdropPath, ImageTypes.Backdrop, ImageSizes.Medium),
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Small),
                PosterImageUrlOriginal = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Original),
                Genres = source.Genres.Select(x => Create(x)).ToList(),
                ProductionCompanies = source.ProductionCompanies.Select(x => Create(x)).ToList(),
                Directors = source.Credits.Crew.Where(x => _directorJobNames.Contains(x.Job)).Select(x => Create(x)).ToList(),
                Producers = source.Credits.Crew.Where(x => _producerJobNames.Contains(x.Job)).Select(x => Create(x)).ToList(),
                Writers = source.Credits.Crew.Where(x => x.Department == "Writing").Select(x => Create(x)).ToList(),
                TopBilledCast = source.Credits.Cast.OrderBy(x => x.Order).Take(6).Select(x => Create(x)).ToList()
            };
        }

        /// <summary>
        /// Creates an import movie result model from an extended movie result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Import movie result model</returns>
        public ImportMovieResultModel CreateImport(ExtendedMovieResult source)
        {
            return new ImportMovieResultModel
            {
                Budget = source.Budget,
                HomePage = source.HomePage,
                Id = source.Id,
                ImdbId = source.ImdbId,
                Overview = source.Overview,
                ReleaseDate = source.ReleaseDate.GetValueOrDefault().ToShortDateString(),
                Revenue = source.Revenue,
                Runtime = source.Runtime,
                Tagline = source.Tagline,
                Title = source.Title,
                BackdropImageUrl = FormalizeImagePath(source.BackdropPath, ImageTypes.Backdrop, ImageSizes.Smallest),
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Small),
                Genres = source.Genres.Select(x => Create(x)).ToList()
            };
        }

        /// <summary>
        /// Creates a crew group result model from an external crew group result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Crew group result model</returns>
        public CrewGroupResultModel Create(IGrouping<string, CrewResult> source)
        {
            return new CrewGroupResultModel
            {
                Department = source.Key,
                Members = source.ToList().Select(x => Create(x, ImageSizes.Smallest))
            };
        }

        /// <summary>
        /// Creates a crew result model from an external crew result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="profileImageSize">Size of the profile image.</param>
        /// <returns>Crew result model</returns>
        public CrewResultModel Create(CrewResult source, ImageSizes profileImageSize = ImageSizes.Small)
        {
            return new CrewResultModel
            {
                Id = source.Id,
                Job = source.Job,
                Name = source.Name,
                ProfileImageUrl = FormalizeImagePath(source.ProfilePath, ImageTypes.Profile, profileImageSize),
                ProfileImageUrlOriginal = FormalizeImagePath(source.ProfilePath, ImageTypes.Profile, ImageSizes.Original)
            };
        }

        /// <summary>
        /// Creates a cast result model from an external cast result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="profileImageSize">Size of the profile image.</param>
        /// <returns>Cast result model</returns>
        public CastResultModel Create(CastResult source, ImageSizes profileImageSize = ImageSizes.Small)
        {
            return new CastResultModel
            {
                Character = source.Character,
                Id = source.Id,
                Name = source.Name,
                Order = source.Order,
                ProfileImageUrl = FormalizeImagePath(source.ProfilePath, ImageTypes.Profile, profileImageSize),
                ProfileImageUrlOriginal = FormalizeImagePath(source.ProfilePath, ImageTypes.Profile, ImageSizes.Original)
            };
        }

        /// <summary>
        /// Creates an extended person result model from an external result model.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Extended person result model</returns>
        public ExtendedPersonResultModel Create(ExtendedPersonResult source)
        {
            return new ExtendedPersonResultModel
            {
                Aliases = source.AlsoKnownAs,
                Biography = source.Biography,
                Birthday = source.Birthday,
                Deathday = source.Deathday,
                HomePage = source.HomePage,
                Id = source.Id,
                ImdbId = source.ImdbId,
                Name = source.Name,
                PlaceOfBirth = source.PlaceOfBirth,
                ProfileImageUrl = FormalizeImagePath(source.ProfilePath, ImageTypes.Profile, ImageSizes.Small),
                ProfileImageUrlOriginal = FormalizeImagePath(source.ProfilePath, ImageTypes.Profile, ImageSizes.Original),
                Images = source.Images.Profiles.Select(x => Create(x, ImageSizes.Small)),
                CastCredits = source.Credits.Cast.Select(x => Create(x)),
                CrewCredits = source.Credits.Crew.Select(x => Create(x))
            };
        }

        /// <summary>
        /// Creates an image result model from an external image result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="size">The size.</param>
        /// <returns>Image result model</returns>
        public ImageResultModel Create(ImageResult source, ImageSizes size)
        {
            return new ImageResultModel
            {
                AspectRatio = source.AspectRatio,
                Height = source.Height,
                Width = source.Width,
                ImageUrl = FormalizeImagePath(source.FilePath, ImageTypes.Profile, size),
                ImageUrlOriginal = FormalizeImagePath(source.FilePath, ImageTypes.Profile, ImageSizes.Original)
            };
        }

        /// <summary>
        /// Creates a cast credit result model from an external cast credit result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Cast credit result model</returns>
        public CastCreditResultModel Create(CastCreditResult source)
        {
            return new CastCreditResultModel()
            {
                Character = source.Character,
                CreditId = source.CreditId,
                EpisodeCount = source.EpisodeCount,
                FirstAirYear = source.FirstAirDate?.Year,
                Id = source.Id,
                IsMovieCredit = source.MediaType == MediaTypes.Movie,
                IsTvCredit = source.MediaType == MediaTypes.TV,
                Name = source.Name,
                ReleaseYear = source.ReleaseDate?.Year,
                Title = source.Title,
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Smallest)
            };
        }

        /// <summary>
        /// Creates a crew credit result model from an external crew credit result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Crew credit result model</returns>
        public CrewCreditResultModel Create(CrewCreditResult source)
        {
            return new CrewCreditResultModel
            {
                CreditId = source.CreditId,
                Department = source.Department,
                EpisodeCount = source.EpisodeCount,
                FirstAirYear = source.FirstAirDate?.Year,
                Id = source.Id,
                IsMovieCredit = source.MediaType == MediaTypes.Movie,
                IsTvCredit = source.MediaType == MediaTypes.TV,
                Job = source.Job,
                Name = source.Name,
                ReleaseYear = source.ReleaseDate?.Year,
                Title = source.Title,
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Smallest)
            };
        }

        /// <summary>
        /// Creates a full credit result model from an external extended movie result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Full credit result model</returns>
        public FullCreditsResultModel CreateCredits(ExtendedMovieResult source)
        {
            return new FullCreditsResultModel
            {
                Overview = source.Overview,
                Tagline = source.Tagline,
                Title = source.Title,
                BackdropImageUrl = FormalizeImagePath(source.BackdropPath, ImageTypes.Backdrop, ImageSizes.Medium),
                PosterImageUrl = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Small),
                PosterImageUrlOriginal = FormalizeImagePath(source.PosterPath, ImageTypes.Poster, ImageSizes.Original),
                Genres = source.Genres.Select(x => Create(x)).ToList(),
                Cast = source.Credits.Cast.OrderBy(x => x.Order).Select(x => Create(x, ImageSizes.Smallest)),
                Crew = source.Credits.Crew.GroupBy(x => x.Department).Select(x => Create(x)),
                Departments = source.Credits.Crew.Select(x => x.Department).Distinct().OrderBy(x => x)
            };
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Formalizes the image path.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="type">The type.</param>
        /// <param name="size">The size.</param>
        /// <returns>The formalized image path</returns>
        private string FormalizeImagePath(string sourcePath, ImageTypes type, ImageSizes size)
        {
            if (!string.IsNullOrWhiteSpace(sourcePath))
            {
                return _imageHelper.GetImagePath(type, size) + sourcePath;
            }

            return string.Empty;
        }

        /// <summary>
        /// Parses the movie genres.
        /// </summary>
        /// <param name="genreIds">The genre ids.</param>
        /// <returns>The movie genres</returns>
        private List<NamedItemModel> ParseMovieGenres(List<int> genreIds)
        {
            List<NamedItemModel> movieGenres;

            if (_genres != null && genreIds != null)
            {
                movieGenres = (from x in _genres
                               where genreIds.Contains(x.Id)
                               select new NamedItemModel
                               {
                                   Id = x.Id,
                                   Name = x.Name
                               }).ToList();
            }
            else
            {
                movieGenres = new List<NamedItemModel>();
            }

            return movieGenres;
        }

        #endregion Private Methods
    }
}