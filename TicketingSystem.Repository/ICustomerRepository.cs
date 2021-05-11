// <copyright file="ICustomerRepository.cs" company="PlaceholderCompany">
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
    public interface ICustomerRepository : IRepository<Customer>
    {
        /// <summary>
        /// Method for changing price of ticket.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        /// <param name="newPrice">The id to join.</param>
        void ChangePriceOfTicket(int id, int newPrice);

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
        /// <param name="priceOfTicket">The price to join.</param>
        public void Modify(int id, int priceOfTicket);
    }
}
