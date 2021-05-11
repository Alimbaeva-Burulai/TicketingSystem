// <copyright file="Repository.cs" company="PlaceholderCompany">
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
    ///  This class performs an important function.
    /// </summary>/// <typeparam name="T">The first generic type parameter.</typeparam>
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        private DbContext ctx;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// The class constructor.
        /// </summary>
        /// <param name="ctx">The entity to join.</param>
        protected Repository(DbContext ctx)
        {
            this.Ctx = ctx;
        }

        /// <summary>
        /// Gets or Sets DbContext field so the child can reach it.
        /// </summary>
        protected DbContext Ctx { get => this.ctx; set => this.ctx = value; }

        /// <summary>
        /// Joins a first name and a last name together into a single string.
        /// </summary>
        /// /// <returns>It returns IQueryable type.</returns>
        public IQueryable<T> GetAll()
        {
            return this.Ctx.Set<T>();
        }

        /// <summary>
        /// Joins a first name and a last name together into a single string.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        /// /// <returns>It returns T type.</returns>
        public abstract T GetOne(int id);

        /// <summary>
        /// Joins a first name and a last name together into a single string.
        /// </summary>
        /// <param name="entity">The entity to join.</param>
        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Joins a first name and a last name together into a single string.
        /// </summary>
        /// <param name="entity">The entity to join.</param>
        /// <param name="id">The id to join.</param>
        /// <returns>The joined names will be removed.</returns>
        public bool Remove(T entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
