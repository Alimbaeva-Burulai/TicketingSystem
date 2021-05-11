// <copyright file="ITicketRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TicketingSystem.Data;
    using TicketingSystem.Data.CodeFirstDB;

    /// <summary>
    /// Documentation that describes the interface goes here.
    /// </summary>
    /// <remarks>
    /// Details about the interface go here.
    /// </remarks>
    public interface ITicketRepository : IRepository<BookingTicket>
    {
        /// <summary>
        /// Method for changing venue.
        /// </summary>
        /// <param name="id">The entity to join.</param>
        /// <param name="newVenue">The id to join.</param>
        void ChangeVenue(int id, int newVenue);

        /// <summary>
        /// Adding name.
        /// </summary>
        /// <param name="number">The entity to join.</param>
        /// <returns>number.</returns>
        public int Add(int number);

        /// <summary>
        /// Removing name.
        /// </summary>
        /// <param name="number">The entity to join.</param>
        /// <returns>number.</returns>
        public int Remove(int number);

        /// <summary>
        /// Modify the entities.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="venue">The venue to join.</param>
        public void Modify(int id, int venue);
    }
}
