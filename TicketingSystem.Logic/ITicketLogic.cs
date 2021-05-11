// <copyright file="ITicketLogic.cs" company="PlaceholderCompany">
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
    public interface ITicketLogic
     {
        /// <summary>
        /// Method for getting one ticket.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns bookingticket.</returns>
        BookingTicket GetOneTicket(int id);

        /// <summary>
        /// Method for changing ticket venue.
        /// </summary>
        /// <param name="ticketId">The id to join.</param>
        /// <param name="venue">The venue to join.</param>
        void ChangeTicketVenue(int ticketId, int venue);

        /// <summary>
        /// Method for getting all tickets.
        /// </summary>
        /// <returns>Returns IList.</returns>
        IList<BookingTicket> GetAllTickets();

        /// <summary>
        /// Method for getting changed venue.
        /// </summary>
        /// <param name="venue">The id to join.</param>
        /// <returns>Reurns Ilist. </returns>
        IList GetChangedVenue(int venue);

        /// <summary>
        /// Removes a specific entry from the database.
        /// </summary>
        /// <param name="number">ID of the entry.</param>
        void Remove(int number);

        /// <summary>
        /// Adding a new entry into a table.
        /// </summary>
        /// <param name="number">New entry.</param>
        void Add(int number);

        /// <summary>
        /// Modify the entities.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="venue">The venue to join.</param>
        void Modify(int id, int venue);
    }
}
