//-----------------------------------------------------------------------
// <copyright file="WebApiConfig.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Mvc
{
    using System.Web.Http;

    /// <summary>
    /// Web API Configuration class
    /// </summary>
    public class WebApiConfig
    {
        /// <summary>
        /// Registers the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
            AddExternalMovieRoutes(config);
        }

        /// <summary>
        /// Adds the external movie routes.
        /// </summary>
        /// <param name="config">The configuration.</param>
        private static void AddExternalMovieRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "ExternalMovies-Collection",
                routeTemplate: "api/external/movies/collections/{id}",
                defaults: new { controller = "ExternalMovieCollection" });

            config.Routes.MapHttpRoute(
               name: "ExternalMovies-Credits",
               routeTemplate: "api/external/movies/details/{id}/credits",
               defaults: new { controller = "ExternalMovieCredits" });

            config.Routes.MapHttpRoute(
               name: "ExternalMovies-Details",
               routeTemplate: "api/external/movies/details/{id}",
               defaults: new { controller = "ExternalMovieDetails", id = RouteParameter.Optional });

            config.Routes.MapHttpRoute(
               name: "ExternalMovies-Import",
               routeTemplate: "api/external/movies/import/{id}",
               defaults: new { controller = "ExternalMovieImport", id = RouteParameter.Optional });

            config.Routes.MapHttpRoute(
                name: "ExternalMovies-Person",
                routeTemplate: "api/external/movies/person/{id}",
                defaults: new { controller = "ExternalMoviePerson" });

            config.Routes.MapHttpRoute(
               name: "ExternalMovies-Search",
               routeTemplate: "api/external/movies/search",
               defaults: new { controller = "ExternalMovieSearch" });
        }
    }
}