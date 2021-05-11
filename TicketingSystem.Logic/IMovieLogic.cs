// <copyright file="IMovieLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using TicketingSystem.Data.CodeFirstDB;

    /// <summary>
    /// Documentation that describes the interface goes here.
    /// </summary>
    /// <remarks>
    /// Details about the interface go here.
    /// </remarks>
    public interface IMovieLogic
    {
        /// <summary>
        /// Method for getting one movie.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns movie.</returns>
        Movie GetOneMovie(int id);

        /// <summary>
        /// Method for changing date of movie.
        /// </summary>
        /// <param name="movieId">The id to join.</param>
        /// <param name="dateOfWatching">The dateOfWatching to join.</param>>
        void ChangeMovieDate(int movieId, string dateOfWatching);

        /// <summary>
        /// Method for getting all movie.
        /// </summary>
        /// <returns>Returns IList.</returns>
        IList<Movie> GetAllMovie();

        /// <summary>
        /// Method for getting changed date.
        /// </summary>
        /// <param name="getdate">The id to join.</param>
        /// <returns>Returns IList.</returns>
        IList GetChangedDate(string getdate);

        /// <summary>
        /// Removes a specific entry from the database.
        /// </summary>
        /// <param name="name">ID of the entry.</param>
        void Remove(string name);

        /// <summary>
        /// Adding a new entry into a table.
        /// </summary>
        /// <param name="name">New entry.</param>
        void Add(string name);

        /// <summary>
        /// Modify the entities.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="language">The language to join.</param>
        void Modify(int id, string language);
    }
}
