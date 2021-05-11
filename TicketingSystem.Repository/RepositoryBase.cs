// <copyright file="RepositoryBase.cs" company="PlaceholderCompany">
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
    /// This abstract class RepositoryBase wih generic type.
    /// </summary> <typeparam name="T">The first generic type parameter.</typeparam>
    public abstract class RepositoryBase<T> : IRepository<T>
        where T : class
    {
        private DbContext ctx;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase{T}"/> class.
        /// The class constructor.
        /// </summary>
        /// <param name="ctx">The entity to join.</param>
        protected RepositoryBase(DbContext ctx)
        {
            this.Ctx = ctx;
        }

        /// <summary>
        /// Gets or Sets DbContext field so the child can reach it.
        /// </summary>
        protected DbContext Ctx { get => this.ctx; set => this.ctx = value; }

        /// <summary>
        /// Meethod for getting all.
        /// </summary>
        /// <returns>It returns IQueryable type.</returns>
        public IQueryable<T> GetAll()
        {
            return this.Ctx.Set<T>();
        }

        /// <summary>
        /// Method for getting one.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        /// <returns>It returns T type.</returns>
        public abstract T GetOne(int id);

        /// <summary>
        /// Method for inserting.
        /// </summary>
        /// <param name="entity">The entity to join.</param>
        public void Insert(T entity)
        {
            this.Ctx.Add<T>(entity);
        }

        /// <summary>
        /// Method for removing id by entity.
        /// </summary>
        /// <param name="entity">The entity to join.</param>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns true or false.</returns>
        public bool Remove(T entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
