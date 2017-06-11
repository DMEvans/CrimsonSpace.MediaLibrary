//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers.UI
{
    using System.Web.Mvc;

    /// <summary>
    /// Home controller
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// Index action
        /// </summary>
        /// <returns>Index view result</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Movie import action.
        /// </summary>
        /// <returns>Movie import view</returns>
        public ActionResult ExternalMovies()
        {
            return View();
        }
    }
}