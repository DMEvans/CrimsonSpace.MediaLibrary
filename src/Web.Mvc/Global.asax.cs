//-----------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Mvc
{
    using ExternalApi.Data.Repositories;
    using ExternalApi.TheMovieDB.Service.Api;
    using Ninject;
    using Ninject.Web.WebApi;
    using SharedLibrary.Data;
    using SharedLibrary.Interfaces;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using Web.Controllers;
    using Web.Mvc.App_Start;

    /// <summary>
    /// Application class
    /// </summary>
    /// <seealso cref="System.Web.HttpApplication" />
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}