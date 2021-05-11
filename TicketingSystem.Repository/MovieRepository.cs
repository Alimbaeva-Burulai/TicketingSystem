// <copyright file="MovieRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using TicketingSystem.Data.CodeFirstDB;

    /// <summary>
    /// This class MovieRepository.
    /// </summary>
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieRepository"/> class.
        /// Constructor MovieRepository.
        /// </summary>
        /// <param name="ctx">The id to join.</param>
        public MovieRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc/>
        public int Add(string name)
        {
            Movie movie = new Movie();
            movie.MovieName = name;
            this.Ctx.Set<Movie>().Add(movie);
            this.Ctx.SaveChanges();
            return movie.MovieId;
        }

        /// <inheritdoc/>
        public void ChangeDate(int id, string dateOfWatching)
        {
            var movie = this.GetOne(id);
            if (movie == null)
            {
                throw new InvalidOperationException("Movie is not found");
            }

            movie.Date = dateOfWatching;
            this.Ctx.SaveChanges();
        }

        /// <inheritdoc/>
        public override Movie GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.MovieId == id);
        }

        /// <inheritdoc/>
        public void Modify(int id, string language)
        {
            Movie movie = new Movie();
            this.Ctx.Set<Movie>().Where(x => x.MovieId == id).First().Language = language;
        }

        /// <inheritdoc/>
        public int Remove(string name)
        {
            Movie movie = new Movie();
            movie.MovieName = name;
            this.Ctx.Set<Movie>().Remove(movie);
            this.Ctx.SaveChanges();
            return movie.MovieId;
        }
    }
}
