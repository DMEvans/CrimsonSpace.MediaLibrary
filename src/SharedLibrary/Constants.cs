//-----------------------------------------------------------------------
// <copyright file="Constants.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary
{
    /// <summary>
    /// Application constant values and enumerates
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Application error messages
        /// </summary>
        public struct ErrorMessages
        {
            /// <summary>
            /// The type must be an enumerate
            /// </summary>
            public const string TypeMustBeAnEnum = "The type must be an enumerate";
        }

        /// <summary>
        /// Application enumerates 
        /// </summary>
        public static class Enums
        {
            /// <summary>
            /// Order by directions
            /// </summary>
            public enum OrderByDirections
            {
                Ascending,
                Descending
            }
        }        
    }
}