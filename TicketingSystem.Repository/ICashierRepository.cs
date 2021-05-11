// <copyright file="ICashierRepository.cs" company="PlaceholderCompany">
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
    public interface ICashierRepository : IRepository<Cashier>
    {
        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        /// <param name="newSalary">The id to join.</param>
        void IncreasingSalary(int id, int newSalary);

        /// <summary>
        /// Adding name.
        /// </summary>
        /// <param name="entry">The entity to join.</param>
        void Add(Cashier entry);

        /// <summary>
        /// Removing name.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        /// /// <returns>Returns bool.</returns>
        bool RemoveCashier(int id);

        /// <summary>
        /// Adding name.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        void Remove(int id);

        /// <summary>
        /// Adding name.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="cashier">The cashier.</param>
        void Modify(int id, Cashier cashier);

        /// <summary>
        /// Modifying name.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="cashier">The salary to join.</param>
        /// <returns>Returns bool.</returns>
        bool ModifyCashier(int id, Cashier cashier);
    }
}
