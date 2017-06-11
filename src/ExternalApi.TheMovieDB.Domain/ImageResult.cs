//-----------------------------------------------------------------------
// <copyright file="ImageResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;

    /// <summary>
    /// Container class for an image result
    /// </summary>
    public class ImageResult
    {
        /// <summary>
        /// Gets or sets the aspect ratio.
        /// </summary>
        /// <value>
        /// The aspect ratio.
        /// </value>
        [JsonProperty("aspect_ratio")]
        public double AspectRatio { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        [JsonProperty("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the ISO 639 language.
        /// </summary>
        /// <value>
        /// The ISO 639 language.
        /// </value>
        [JsonProperty("iso_639_1")]
        public string Iso639 { get; set; }

        /// <summary>
        /// Gets or sets the vote average.
        /// </summary>
        /// <value>
        /// The vote average.
        /// </value>
        [JsonProperty("vote_average")]
        public decimal VoteAverage { get; set; }

        /// <summary>
        /// Gets or sets the vote count.
        /// </summary>
        /// <value>
        /// The vote count.
        /// </value>
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [JsonProperty("width")]
        public int Width { get; set; }
    }
}