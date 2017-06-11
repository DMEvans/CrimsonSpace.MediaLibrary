//-----------------------------------------------------------------------
// <copyright file="ObjectExtensions.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary.Extensions
{
    using System;

    /// <summary>
    /// Application object extensions
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Coverts an object to a date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The converted date time, or the date time minimum value if the conversion failed</returns>
        public static DateTime ToDateTime(this object value)
        {
            DateTime parsedValue;

            if (!DateTime.TryParse(value.ToString(), out parsedValue))
            {
                parsedValue = default(DateTime);
            }

            return parsedValue;
        }

        /// <summary>
        /// Converts an object to an integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The converted integer, or the default integer value if the conversion failed</returns>
        public static int ToInt(this object value)
        {
            int parsedValue;

            if (!int.TryParse(value.ToString(), out parsedValue))
            {
                parsedValue = 0;
            }

            return parsedValue;
        }

        /// <summary>
        /// Converts object to a decimal value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The converted decimal, or the default decimal value if the conversion failed</returns>
        public static decimal ToDecimal(this object value)
        {
            decimal parsedValue;

            if (!decimal.TryParse(value.ToString(), out parsedValue))
            {
                parsedValue = 0;
            }

            return parsedValue;
        }

        /// <summary>
        /// Converts an object to boolean value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The converted boolean, or the default boolean value if the conversion failed</returns>
        public static bool ToBool(this object value)
        {
            bool parsedValue;

            if (!bool.TryParse(value.ToString(), out parsedValue))
            {
                parsedValue = false;
            }

            return parsedValue;
        }
    }
}