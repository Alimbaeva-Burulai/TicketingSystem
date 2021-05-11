// <copyright file="IMovieRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TicketingSystem.Data.CodeFirstDB;

    /// <summary>
    /// Documentation that describes the interface goes here.
    /// </summary>
    /// <remarks>
    /// Details about the interface go here.
    /// </remarks>
    public interface IMovieRepository : IRepository<Movie>
    {
        /// <summary>
        /// Method for changing date.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        /// <param name="dateOfWatching">The string to join.</param>
        void ChangeDate(int id, string dateOfWatching);

        /// <summary>
        /// Adding name.
        /// </summary>
        /// <param name="name">The entity to join.</param>
        /// <returns>number.</returns>
        public int Add(string name);

        /// <summary>
        /// Removing name.
        /// </summary>
        /// <param name="name">The entity to join.</param>
        /// <returns>number.</returns>
        public int Remove(string name);

        /// <summary>
        /// Modify the entities.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="language">The language to join.</param>
        public void Modify(int id, string language);
    }
}
