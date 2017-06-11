//-----------------------------------------------------------------------
// <copyright file="DisconnectedDataRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary.Data
{
    using SharedLibrary.Extensions;
    using SharedLibrary.Interfaces;
    using SharedLibrary.Objects;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Disconnected generic data repository
    /// </summary>
    /// <typeparam name="T1">The database context type.</typeparam>
    /// <typeparam name="T2">The entity type.</typeparam>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{T2}" />
    public class DisconnectedDataRepository<T1, T2> : IGenericDataRepository<T2> where T1 : DbContext where T2 : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the maximum results.  This is reset to zero (no maximum) after each query executed.
        /// </summary>
        /// <value>
        /// The maximum number of results.
        /// </value>
        public int MaxResults { get; set; } = 0;

        /// <summary>
        /// Gets or sets the number of results to skip.  This is reset to zero after each query executed.
        /// </summary>
        /// <value>
        /// The number of results to skip.
        /// </value>
        public int SkipResults { get; set; } = 0;

        /// <summary>
        /// Gets or sets the type of the entity model.
        /// </summary>
        /// <value>
        /// The type of the entity model.
        /// </value>
        protected Type EntityModelType { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Adds the specified items.
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <returns>
        /// The inserted Id value
        /// </returns>
        public int Add(T2 item)
        {
            using (var context = GetContextInstance())
            {
                context.Entry(item).State = EntityState.Added;
                context.SaveChanges();
            }

            return item.Id;
        }

        /// <summary>
        /// Check if an item exists.
        /// </summary>
        /// <param name="where">The query.</param>
        /// <returns>
        /// <c>true</c> if any items match the query; otherwise, <c>false</c>.
        /// </returns>
        public bool Exists(Func<T2, bool> where)
        {
            using (var context = GetContextInstance())
            {
                IQueryable<T2> query = context.Set<T2>();
                return query.Any(where);
            }
        }

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>All items</returns>
        public IList<T2> GetAll(params Expression<Func<T2, object>>[] navigationProperties)
        {
            return GetAll(null, navigationProperties);
        }

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <param name="orderBy">The sort expression</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>All items</returns>
        public IList<T2> GetAll(OrderByParameters<T2, object> orderBy, params Expression<Func<T2, object>>[] navigationProperties)
        {
            List<T2> list;

            using (var context = GetContextInstance())
            {
                IQueryable<T2> query = context.Set<T2>();

                foreach (var navigationProperty in navigationProperties)
                {
                    query = query.Include<T2, object>(navigationProperty);
                }

                query = query.AsNoTracking();
                query = query.ApplyOrderByParameters(orderBy);

                if (SkipResults > 0)
                {
                    query = query.Skip(SkipResults);
                }

                if (MaxResults > 0)
                {
                    query = query.Take(MaxResults);
                }

                list = query.ToList<T2>();
            }

            ResetProperties();

            return list;
        }

        /// <summary>
        /// Gets items based on a predefined LINQ query.
        /// </summary>
        /// <param name="where">The predefined query</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>Matching items</returns>
        public IList<T2> GetFiltered(Func<T2, bool> where, params Expression<Func<T2, object>>[] navigationProperties)
        {
            return GetFiltered(where, null, navigationProperties);
        }

        /// <summary>
        /// Gets items based on a predefined LINQ query.
        /// </summary>
        /// <param name="where">The predefined query</param>
        /// <param name="orderBy">The sort expression</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>Matching items</returns>
        public IList<T2> GetFiltered(Func<T2, bool> where, OrderByParameters<T2, object> orderBy, params Expression<Func<T2, object>>[] navigationProperties)
        {
            List<T2> list;

            using (var context = GetContextInstance())
            {
                IQueryable<T2> query = context.Set<T2>();

                foreach (var navigationProperty in navigationProperties)
                {
                    query = query.Include<T2, object>(navigationProperty);
                }

                query = query.Where(where).AsQueryable();
                query = query.AsNoTracking();
                query = query.ApplyOrderByParameters(orderBy);

                if (SkipResults > 0)
                {
                    query = query.Skip(SkipResults);
                }

                if (MaxResults > 0)
                {
                    query = query.Take(MaxResults);
                }

                list = query.ToList<T2>();
            }

            ResetProperties();

            return list;
        }

        /// <summary>
        /// Gets the single item from a predefined query.
        /// </summary>
        /// <param name="where">The predefined query</param>
        /// <param name="navigationProperties">The navigation properties.</param>
        /// <returns>Matching item if found, else null</returns>
        public T2 GetSingle(Func<T2, bool> where, params Expression<Func<T2, object>>[] navigationProperties)
        {
            T2 item = null;

            using (var context = GetContextInstance())
            {
                IQueryable<T2> query = context.Set<T2>();

                foreach (var navigationProperty in navigationProperties)
                {
                    query = query.Include<T2, object>(navigationProperty);
                }

                item = query.AsNoTracking().FirstOrDefault(where);
            }

            ResetProperties();

            return item;
        }

        /// <summary>
        /// Removes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void Remove(params T2[] items)
        {
            using (var context = GetContextInstance())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void Update(params T2[] items)
        {
            using (var context = GetContextInstance())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets the context instance.
        /// </summary>
        /// <returns>Context instance</returns>
        protected DbContext GetContextInstance()
        {
            return Activator.CreateInstance<T1>();
        }

        /// <summary>
        /// Resets the properties.
        /// </summary>
        private void ResetProperties()
        {
            MaxResults = 0;
            SkipResults = 0;
        }

        #endregion Private Methods
    }
}