//-----------------------------------------------------------------------
// <copyright file="CastCreditResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Model class for a cast credit result
    /// </summary>
    /// <seealso cref="Web.Models.ExternalMovies.BasePersonCreditResultModel" />
    public class CastCreditResultModel : BasePersonCreditResultModel
    {
        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>
        /// The character.
        /// </value>
        public string Character { get; set; }
    }
}