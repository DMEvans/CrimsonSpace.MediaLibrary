//-----------------------------------------------------------------------
// <copyright file="CastResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Model class for a movie cast result
    /// </summary>
    /// <seealso cref="Web.Models.ExternalMovies.BasePersonResultModel" />
    public class CastResultModel : BasePersonResultModel
    {
        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>
        /// The character.
        /// </value>
        public string Character { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }
    }
}