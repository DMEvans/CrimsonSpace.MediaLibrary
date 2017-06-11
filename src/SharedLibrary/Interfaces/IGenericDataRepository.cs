//-----------------------------------------------------------------------
// <copyright file="IGenericDataRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary.Interfaces
{
    using SharedLibrary.Objects;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Generic data repository
    /// </summary>
    /// <typeparam name="T">Data entity</typeparam>
    public interface IGenericDataRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Gets or sets the maximum results.
        /// </summary>
        /// <value>
        /// The maximum results.
        /// </value>
        int MaxResults { get; set; }

        /// <summary>
        /// Gets or sets the number of results to skip.
        /// </summary>
        /// <value>
        /// The number of results to skip.
        /// </value>
        int SkipResults { get; set; }

        /// <summary>
        /// Adds the specified items.
        /// </summary>
        /// <param name="item">The items.</param>
        /// <returns>The inserted Id value</returns>
        int Add(T item);

        /// <summary>
        /// Check if an item exists.
        /// </summary>
        /// <param name="where">The query.</param>
        /// <returns>
        /// <c>true</c> if any items match the query; otherwise, <c>false</c>.
        /// </returns>
        bool Exists(Func<T, bool> where);

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>All items</returns>
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <param name="orderBy">The order by.</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>All items</returns>
        IList<T> GetAll(OrderByParameters<T, object> orderBy, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Gets results with specified filter.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>Matching items</returns>
        IList<T> GetFiltered(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Gets results with specified filter.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>Matching items</returns>
        IList<T> GetFiltered(Func<T, bool> where, OrderByParameters<T, object> orderBy, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Gets single item.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>Matching item, or null if no item found</returns>
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Removes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        void Remove(params T[] items);

        /// <summary>
        /// Updates the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        void Update(params T[] items);
    }
}