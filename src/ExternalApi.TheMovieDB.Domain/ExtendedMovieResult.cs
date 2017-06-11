//-----------------------------------------------------------------------
// <copyright file="ExtendedMovieResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Base;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Extended movie result container class
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.BasicMovieResult" />
    public class ExtendedMovieResult : BaseMovieResult
    {
        /// <summary>
        /// Gets or sets the budget.
        /// </summary>
        /// <value>
        /// The budget.
        /// </value>
        [JsonProperty(PropertyName = "budget")]
        public double Budget { get; set; }

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        /// <value>
        /// The collection.
        /// </value>
        [JsonProperty(PropertyName = "belongs_to_collection")]
        public BasicCollectionResult Collection { get; set; }

        /// <summary>
        /// Gets or sets the credits.
        /// </summary>
        /// <value>
        /// The credits.
        /// </value>
        [JsonIgnore]
        public MovieCreditResult Credits { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        [JsonProperty("genres")]
        public IList<GenreResult> Genres { get; set; }

        /// <summary>
        /// Gets or sets the home page.
        /// </summary>
        /// <value>
        /// The home page.
        /// </value>
        [JsonProperty(PropertyName = "homepage")]
        public string HomePage { get; set; }

        /// <summary>
        /// Gets or sets the Internet Movie Database identifier.
        /// </summary>
        /// <value>
        /// The Internet Movie Database identifier.
        /// </value>
        [JsonProperty(PropertyName = "imdb_id")]
        public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the production companies.
        /// </summary>
        /// <value>
        /// The production companies.
        /// </value>
        [JsonProperty(PropertyName = "production_companies")]
        public List<ProductionCompanyResult> ProductionCompanies { get; set; }

        /// <summary>
        /// Gets or sets the production countries.
        /// </summary>
        /// <value>
        /// The production countries.
        /// </value>
        [JsonProperty(PropertyName = "production_countries")]
        public List<RegionResult> ProductionCountries { get; set; }

        /// <summary>
        /// Gets or sets the revenue.
        /// </summary>
        /// <value>
        /// The revenue.
        /// </value>
        [JsonProperty(PropertyName = "revenue")]
        public double Revenue { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        [JsonProperty(PropertyName = "runtime")]
        public int Runtime { get; set; }

        /// <summary>
        /// Gets or sets the spoken languages.
        /// </summary>
        /// <value>
        /// The spoken languages.
        /// </value>
        [JsonProperty(PropertyName = "spoken_languages")]
        public List<LanguageResult> SpokenLanguages { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the tagline.
        /// </summary>
        /// <value>
        /// The tagline.
        /// </value>
        [JsonProperty(PropertyName = "tagline")]
        public string Tagline { get; set; }
    }
}