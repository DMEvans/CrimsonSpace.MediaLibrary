//-----------------------------------------------------------------------
// <copyright file="Paginator.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary.Helpers
{
    using System;
    using System.Text;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Helper class for providing HTML pagination in an MVC application
    /// </summary>
    public class Paginator
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="Paginator"/> class.
        /// </summary>
        /// <param name="viewContext">The view context.</param>
        /// <param name="currentPage">The current page.</param>
        /// <param name="totalPages">The total pages.</param>
        /// <param name="routeValues">The route values.</param>
        public Paginator(ViewContext viewContext, int currentPage, int totalPages, object routeValues)
        {
            CurrentPage = currentPage;
            TotalPages = totalPages;
            RouteValues = routeValues;
            Controller = viewContext.RouteData.Values["controller"].ToString();
            Action = viewContext.RouteData.Values["action"].ToString();
            RequestContext = viewContext.RequestContext;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>
        /// The action.
        /// </value>
        protected string Action { get; set; }

        /// <summary>
        /// Gets or sets the controller.
        /// </summary>
        /// <value>
        /// The controller.
        /// </value>
        protected string Controller { get; set; }

        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        protected int CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the class name to be applied to the element indicating the current page.
        /// </summary>
        /// <value>
        /// The class name to be applied to the element indicating the current page.
        /// </value>
        protected string CurrentPageClassName { get; set; } = "active";

        /// <summary>
        /// Gets or sets the number pages in view.
        /// </summary>
        /// <value>
        /// The number pages in view.
        /// </value>
        protected int NumberPagesInView { get; set; } = 10;

        /// <summary>
        /// Gets or sets the output.
        /// </summary>
        /// <value>
        /// The output.
        /// </value>
        protected StringBuilder Output { get; set; }

        /// <summary>
        /// Gets or sets the variable name to be used in the output query string for the page index.
        /// </summary>
        /// <value>
        /// The variable name to be used in the output query string for the page index.
        /// </value>
        protected string PageVariableName { get; set; } = "page";

        /// <summary>
        /// Gets or sets the class name that will be applied to the pagination control.
        /// </summary>
        /// <value>
        /// The class name that will be applied to the pagination control.
        /// </value>
        protected string PaginationClassName { get; set; } = "pagination";

        /// <summary>
        /// Gets or sets the request context.
        /// </summary>
        /// <value>
        /// The request context.
        /// </value>
        protected RequestContext RequestContext { get; set; }

        /// <summary>
        /// Gets or sets the route values.
        /// </summary>
        /// <value>
        /// The route values.
        /// </value>
        protected object RouteValues { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the first/last buttons on the pagination control where appropriate.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the first/last buttons should be shown on the pagination control where appropriate; otherwise, <c>false</c>.
        /// </value>
        protected bool ShowFirstLastButtons { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the next/previous buttons on the pagination control where appropriate.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the next/previous buttons should be shown on the pagination control where appropriate; otherwise, <c>false</c>.
        /// </value>
        protected bool ShowNextPreviousButtons { get; set; }

        /// <summary>
        /// Gets or sets the total pages.
        /// </summary>
        /// <value>
        /// The total pages.
        /// </value>
        protected int TotalPages { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Generates this instance.
        /// </summary>
        /// <returns>HTML markup for paginator</returns>
        public IHtmlString Generate()
        {
            Output = new StringBuilder();

            Output.AppendLine(string.Format("<ul class=\"{0}\">", PaginationClassName));

            CreatePages();

            Output.AppendLine("</ul>");

            return MvcHtmlString.Create(Output.ToString());
        }

        /// <summary>
        /// Sets the action.
        /// </summary>
        /// <param name="actionName">Name of the action.</param>
        public void SetAction(string actionName)
        {
            Action = actionName;
        }

        /// <summary>
        /// Sets the class name for current page.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        public void SetClassNameForCurrentPage(string className)
        {
            CurrentPageClassName = className;
        }

        /// <summary>
        /// Sets the controller.
        /// </summary>
        /// <param name="controllerName">Name of the controller.</param>
        public void SetController(string controllerName)
        {
            Controller = controllerName;
        }

        /// <summary>
        /// Sets the number of pages in view.
        /// </summary>
        /// <param name="numberOfPages">The number of pages.</param>
        public void SetNumberOfPagesInView(int numberOfPages)
        {
            NumberPagesInView = numberOfPages;
        }

        /// <summary>
        /// Sets the page name variable.
        /// </summary>
        /// <param name="variableName">Name of the variable.</param>
        public void SetPageNameVariable(string variableName)
        {
            PageVariableName = variableName;
        }

        /// <summary>
        /// Sets the name of the pagination class.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        public void SetPaginationClassName(string className)
        {
            PaginationClassName = className;
        }

        /// <summary>
        /// Sets the show first last buttons.
        /// </summary>
        /// <param name="show">if set to <c>true</c> [show].</param>
        public void SetShowFirstLastButtons(bool show)
        {
            ShowFirstLastButtons = show;
        }

        /// <summary>
        /// Sets the show next previous buttons.
        /// </summary>
        /// <param name="show">if set to <c>true</c> [show].</param>
        public void SetShowNextPreviousButtons(bool show)
        {
            ShowNextPreviousButtons = show;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Creates the pages.
        /// </summary>
        private void CreatePages()
        {
            var pagesToDraw = Math.Min(TotalPages, NumberPagesInView);
            var midPoint = (int)Math.Floor((decimal)NumberPagesInView / 2);
            var startPage = 1;
            var endPage = pagesToDraw;

            if (CurrentPage > midPoint)
            {
                startPage = CurrentPage <= midPoint ? 1 : (CurrentPage - midPoint) + 1;
                endPage = startPage + pagesToDraw > TotalPages ? TotalPages : startPage + pagesToDraw;
            }

            var urlHelper = new UrlHelper(RequestContext);

            for (int i = startPage; i <= endPage; i++)
            {
                if (i == CurrentPage)
                {
                    Output.AppendLine(string.Format("<li class=\"{0}\">", CurrentPageClassName));
                }
                else
                {
                    Output.AppendLine("<li>");
                }

                var values = CreateRouteValueDictionary();
                values.Add(PageVariableName, i);

                var url = urlHelper.Action(Action, Controller, values);
                Output.AppendLine(string.Format("<a href=\"{0}\">{1}</a>", url, i));

                Output.AppendLine("</li>");
            }
        }

        /// <summary>
        /// Creates the route value dictionary from the route values object.
        /// </summary>
        /// <returns>The route value dictionary</returns>
        private RouteValueDictionary CreateRouteValueDictionary()
        {
            var values = new RouteValueDictionary();

            var type = RouteValues.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(RouteValues);
                values.Add(property.Name, value);
            }

            return values;
        }

        #endregion Private Methods
    }
}