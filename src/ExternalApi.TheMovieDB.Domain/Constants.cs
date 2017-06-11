//-----------------------------------------------------------------------
// <copyright file="Constants.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    /// <summary>
    /// The Movie DB API handler constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The external source name
        /// </summary>
        public const string ExternalSourceName = "The Movie Database";

        /// <summary>
        /// Gender enumerates
        /// </summary>
        public enum Genders
        {
            Unknown = 0,
            Female = 1,
            Male = 2
        }

        /// <summary>
        /// Image sizes enumerate
        /// </summary>
        public enum ImageSizes
        {
            Smallest = -99,
            ExtraSmall = -2,
            Small = -1,
            Medium = 0,
            Large = 1,
            ExtraLarge = 2,
            Largest = 99,
            Original = 100
        }

        /// <summary>
        /// Image type enumerates
        /// </summary>
        public enum ImageTypes
        {
            Backdrop,
            Logo,
            Poster,
            Still,
            Profile
        }

        /// <summary>
        /// Media type enumerates
        /// </summary>
        public enum MediaTypes
        {
            Movie = 0,
            TV = 1
        }

        /// <summary>
        /// The Movie Database API URLs
        /// </summary>
        public struct ApiUrls
        {
            /// <summary>
            /// Collection API URLs
            /// </summary>
            public struct Collection
            {
                /// <summary>
                /// The collection API details URL
                /// </summary>
                public const string Details = "https://api.themoviedb.org/3/collection/{0}";

                /// <summary>
                /// The collection API images URL
                /// </summary>
                public const string Images = "https://api.themoviedb.org/3/collection/{0}/images";
            }

            /// <summary>
            /// Configuration API URLs
            /// </summary>
            public struct Configuration
            {
                /// <summary>
                /// The configuration API details URL
                /// </summary>
                public const string Details = "https://api.themoviedb.org/3/configuration";
            }

            /// <summary>
            /// Movie API URLs
            /// </summary>
            public struct Movie
            {
                /// <summary>
                /// The movie API credits URL
                /// </summary>
                public const string Credits = "https://api.themoviedb.org/3/movie/{0}/credits";

                /// <summary>
                /// The movie API details URL
                /// </summary>
                public const string Details = "https://api.themoviedb.org/3/movie/{0}";

                /// <summary>
                /// The movie API genres URL
                /// </summary>
                public const string Genres = "https://api.themoviedb.org/3/genre/movie/list";

                /// <summary>
                /// The movie API search URL
                /// </summary>
                public const string Search = "https://api.themoviedb.org/3/search/movie";
            }

            /// <summary>
            /// Person API URLs
            /// </summary>
            public struct Person
            {
                /// <summary>
                /// The person API details URL
                /// </summary>
                public const string Details = "https://api.themoviedb.org/3/person/{0}";

                /// <summary>
                /// The person API credits URL
                /// </summary>
                public const string Credits = "https://api.themoviedb.org/3/person/{0}/combined_credits";

                /// <summary>
                /// The person API images URL
                /// </summary>
                public const string Images = "https://api.themoviedb.org/3/person/{0}/images";
            }

            /// <summary>
            /// TV API URLs
            /// </summary>
            public struct TV
            {
                /// <summary>
                /// The TV API genres URL
                /// </summary>
                public const string Genres = "https://api.themoviedb.org/3/genre/tv/list";
            }
        }
    }
}