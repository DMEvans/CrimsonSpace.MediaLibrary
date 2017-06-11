//-----------------------------------------------------------------------
// <copyright file="NinjectWebCommon.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Web.Mvc.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Web.Mvc.App_Start.NinjectWebCommon), "Stop")]

namespace Web.Mvc.App_Start
{
    using ExternalApi.Data.Interfaces;
    using ExternalApi.Data.Repositories;
    using ExternalApi.TheMovieDB.Service.Api;
    using ExternalApi.TheMovieDB.Service.Api.Interfaces;
    using Library.Data.Interfaces;
    using Library.Data.Repositories;
    using Library.Service;
    using Library.Service.Interfaces;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.WebApi;
    using System;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;
    using Web.Controllers;

    /// <summary>
    /// Ninject web common class
    /// </summary>
    public static class NinjectWebCommon
    {
        /// <summary>
        /// The bootstrapper
        /// </summary>
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);

                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);

                ControllerBuilder.Current.SetControllerFactory(new InjectorControllerFactory(kernel));
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IConfigurationApi>().To<ConfigurationApi>().InSingletonScope();
            kernel.Bind<IGenreApi>().To<GenreApi>();
            kernel.Bind<IMovieApi>().To<MovieApi>();
            kernel.Bind<IPersonApi>().To<PersonApi>();
            kernel.Bind<IExternalSourceRepository>().To<ExternalSourceRepository>();
            kernel.Bind<ICrewDepartmentRepository>().To<CrewDepartmentRepository>();
            kernel.Bind<ICrewRoleRepository>().To<CrewRoleRepository>();
            kernel.Bind<IGenreRepository>().To<GenreRepository>();
            kernel.Bind<IMovieCastRepository>().To<MovieCastRepository>();
            kernel.Bind<IMovieCrewRepository>().To<MovieCrewRepository>();
            kernel.Bind<IMovieGenreLinkRepository>().To<MovieGenreLinkRepository>();
            kernel.Bind<IMovieRepository>().To<MovieRepository>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
            kernel.Bind<IMovieService>().To<MovieService>();
        }
    }
}