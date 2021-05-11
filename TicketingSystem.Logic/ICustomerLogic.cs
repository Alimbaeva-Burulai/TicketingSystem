// <copyright file="ICustomerLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Logic
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
    public interface ICustomerLogic
    {
        /// <summary>
        /// Method for getting one customer.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns Customer.</returns>
        Customer OneCustomer(int id);

        /// <summary>
        /// Method for changing price.
        /// </summary>
        /// <param name="customerId">The id to join.</param>
        /// <param name="price">The price to join.</param>>
        void ChangePrice(int customerId, int price);

        /// <summary>
        /// Method for getting collection of all customers.
        /// </summary>
        /// <returns>Returns IList.</returns>
        IList<Customer> AllCustomers();

        /// <summary>
        /// Method for getting average of ticket price.
        /// </summary>
        /// <returns>The joined names will be removed.</returns>
        IList<AveragesResult> GetTicketPriceAverages();

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
        /// <param name="priceOfTicket">The priceOfTicket to join.</param>
        void Modify(int id, int priceOfTicket);
    }
}
