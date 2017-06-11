//-----------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Mvc
{
    using System.Web.Optimization;

    /// <summary>
    /// Bundle configuration
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Registers the bundles.
        /// </summary>
        /// <param name="bundles">The bundles.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js-libraries")
                                        .Include("~/Content/jquery/jquery-3.1.1.min.js",
                                                 "~/Content/bootstrap/js/bootstrap.js",
                                                 "~/Content/angular/angular.js",
                                                 "~/Content/angular/angular-route/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/local-js")
                                        .Include("~/App/App.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                                       .Include("~/Content/bootstrap/css/bootstrap.min.css",
                                                "~/Content/styles/site.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/external-movies")
                                        .Include("~/App/ExternalMovies/App.js")
                                        .Include("~/App/ExternalMovies/Controllers/*.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}