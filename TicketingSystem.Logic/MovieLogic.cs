// <copyright file="MovieLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TicketingSystem.Data.CodeFirstDB;
    using TicketingSystem.Repository;

    /// <summary>
    /// This class MovieLogic.
    /// </summary>
    public class MovieLogic : IMovieLogic
    {
        /// <summary>
        /// readonly movieRepo field.
        /// </summary>
        private readonly IMovieRepository movieRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieLogic"/> class.
        /// Constructor for MovieLogic.
        /// </summary>
        /// <param name="movieRepo">The id to join.</param>
        /// <returns>The joined names will be removed.</returns>
        public MovieLogic(IMovieRepository movieRepo)
        {
            this.movieRepo = movieRepo;
        }

        /// <summary>
        /// Adding new movie name.
        /// </summary>
        /// <param name="name">The id to join.</param>
        public void Add(string name)
        {
            this.movieRepo.Add(name);
        }

        /// <summary>
        /// Method for changing movie date.
        /// </summary>
        /// <param name="movieId">The id to join.</param>
        /// <param name="dateOfWatching">The dateOfWatching to join.</param>>
        public void ChangeMovieDate(int movieId, string dateOfWatching)
        {
            this.movieRepo.ChangeDate(movieId, dateOfWatching);
        }

        /// <summary>
        /// Method for getting all movie.
        /// </summary>
        /// <returns>Returns IList.</returns>
        public IList<Movie> GetAllMovie()
        {
            return this.movieRepo.GetAll().ToList();
        }

        /// <summary>
        /// Method for getting changed date.
        /// </summary>
        /// <param name="getdate">The id to join.</param>
        /// <returns>Returns IList.</returns>
        public IList GetChangedDate(string getdate)
        {
            IQueryable<Movie> movies = this.movieRepo.GetAll();
            var q = from movie in movies
                    where movie.Date == getdate
                    select movie;
            return q.ToList();
        }

        /// <summary>
        /// Method for getting one movie.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns movie.</returns>
        public Movie GetOneMovie(int id)
        {
            return this.movieRepo.GetOne(id);
        }

        /// <summary>
        /// Modifying the name of movie.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="language">The language to join.</param>
        public void Modify(int id, string language)
        {
            this.movieRepo.Modify(id, language);
        }

        /// <summary>
        /// Removing the name of movie.
        /// </summary>
        /// <param name="name">The id to join.</param>
        public void Remove(string name)
        {
            this.movieRepo.Remove(name);
        }
    }
}
