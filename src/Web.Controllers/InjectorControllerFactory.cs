//-----------------------------------------------------------------------
// <copyright file="InjectorControllerFactory.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers
{
    using Ninject;
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Controller factory which implements dependency injection using an IoC container
    /// </summary>
    /// <seealso cref="System.Web.Mvc.DefaultControllerFactory" />
    public class InjectorControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// The injector
        /// </summary>
        private StandardKernel _injector;

        /// <summary>
        /// Initialises a new instance of the <see cref="InjectorControllerFactory"/> class.
        /// </summary>
        /// <param name="injector">The injector.</param>
        public InjectorControllerFactory(StandardKernel injector)
        {
            _injector = injector;
        }

        /// <summary>
        /// Retrieves the controller instance for the specified request context and controller type.
        /// </summary>
        /// <param name="requestContext">The context of the HTTP request, which includes the HTTP context and route data.</param>
        /// <param name="controllerType">The type of the controller.</param>
        /// <returns>
        /// The controller instance.
        /// </returns>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            var controller = _injector.Get(controllerType);

            return controller as IController;
        }
    }
}