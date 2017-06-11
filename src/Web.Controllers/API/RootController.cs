//-----------------------------------------------------------------------
// <copyright file="RootController.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers.API
{
    using System.Web.Http;

    /// <summary>
    /// API controller for the root of the web site
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class RootController : ApiController
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="RootController"/> class.
        /// </summary>
        public RootController()
        {
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets this default API response.
        /// </summary>
        /// <returns>Default API response</returns>
        public string Get()
        {
            return "Welcome to the Crimson Space Media Library";
        }

        #endregion Public Methods
    }
}