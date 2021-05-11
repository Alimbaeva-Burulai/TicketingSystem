// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Documentation that describes the interface goes here.
    /// </summary>
    /// <remarks>
    /// Details about the interface go here.
    /// </remarks>
    /// <typeparam name="T">The first generic type parameter.</typeparam>
    public interface IRepository<T>
        where T : class
    {
        /// <summary>
        /// Method for getting one by id.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns T generic type.</returns>
        T GetOne(int id);

        /// <summary>
        /// Method for getting all.
        /// </summary>
        /// <returns>Returns IQueryable of T.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Method for inserting new entity.
        /// </summary>
        /// <param name="entity">The entity to join.</param>
        void Insert(T entity);

        /// <summary>
        /// Method for removing entity by id.
        /// </summary>
        /// <param name="entity">The entity to join.</param>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns true or false.</returns>
        bool Remove(T entity, int id);
    }
}
