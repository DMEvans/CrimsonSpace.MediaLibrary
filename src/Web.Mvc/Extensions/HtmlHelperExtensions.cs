//-----------------------------------------------------------------------
// <copyright file="HtmlHelperExtensions.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Mvc.Extensions
{
    using SharedLibrary.Helpers;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Extension methods for the <seealso cref="HtmlHelper"/> class
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Generates a paginator for the current MVC view
        /// </summary>
        /// <typeparam name="T">The generic type of the page model.</typeparam>
        /// <param name="html">The HTML.</param>
        /// <param name="currentPage">The current page.</param>
        /// <param name="totalPages">The total pages.</param>
        /// <param name="routeValues">The route values.</param>
        /// <returns>HTML paginator markup</returns>
        public static IHtmlString Paginator<T>(this HtmlHelper<T> html, int currentPage, int totalPages, dynamic routeValues)
        {
            var paginator = new Paginator(html.ViewContext, currentPage, totalPages, routeValues);
            return paginator.Generate();
        }

        /// <summary>
        /// Generates a paginator for the current MVC view
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <param name="currentPage">The current page.</param>
        /// <param name="totalPages">The total pages.</param>
        /// <param name="routeValues">The route values.</param>
        /// <returns>HTML paginator markup</returns>
        public static IHtmlString Paginator(this HtmlHelper html, int currentPage, int totalPages, object routeValues)
        {
            var paginator = new Paginator(html.ViewContext, currentPage, totalPages, routeValues);
            return paginator.Generate();
        }
    }
}