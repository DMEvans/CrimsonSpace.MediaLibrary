//-----------------------------------------------------------------------
// <copyright file="ItemNotFoundException.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary.Exceptions
{
    using System;

    /// <summary>
    /// Exception class for an item not found error
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ItemNotFoundException : Exception
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ItemNotFoundException"/> class.
        /// </summary>
        public ItemNotFoundException()
        {
        }

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message => "The specified item could not be found";
    }
}