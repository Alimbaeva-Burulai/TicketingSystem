// <copyright file="TicketLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TicketingSystem.Data.CodeFirstDB;
    using TicketingSystem.Repository;

    /// <summary>
    /// This class TicketLogic.
    /// </summary>
    public class TicketLogic : ITicketLogic
    {
        /// <summary>
        /// Readonly field for ticketRepo.
        /// </summary>
        private readonly ITicketRepository ticketRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketLogic"/> class.
        /// Constructor for TicketLogic.
        /// </summary>
        /// <param name="ticketRepo">The id to join.</param>
        public TicketLogic(ITicketRepository ticketRepo)
        {
            this.ticketRepo = ticketRepo;
        }

        /// <summary>
        /// Adding ticket number.
        /// </summary>
        /// <param name="number">The id to join.</param>
        public void Add(int number)
        {
            this.ticketRepo.Add(number);
        }

        /// <summary>
        /// Method for changing ticket venue.
        /// </summary>
        /// <param name="ticketId">The id to join. </param>
        /// <param name="venue">The price to join. </param>param>
        public void ChangeTicketVenue(int ticketId, int venue)
        {
            this.ticketRepo.ChangeVenue(ticketId, venue);
        }

        /// <summary>
        /// Method for getting all tickets.
        /// </summary>
        /// <returns>returns IList of BookingTicket. </returns>
        public IList<BookingTicket> GetAllTickets()
        {
            return this.ticketRepo.GetAll().ToList();
        }

        /// <summary>
        /// Method for getting changed venue.
        /// </summary>
        /// <param name="venue">The id to join. </param>
        /// <returns>Returns IList. </returns>
        public IList GetChangedVenue(int venue)
        {
            IQueryable<BookingTicket> tickets = this.ticketRepo.GetAll();
            var q = from ticket in tickets
                    where ticket.TicketVenue == venue
                    select ticket;
            return q.ToList();
        }

        /// <summary>
        /// Method for getting one ticket.
        /// </summary>
        /// <param name="id">The id to join. </param>
        /// <returns>Returns BookingTicket. </returns>
        public BookingTicket GetOneTicket(int id)
        {
            return this.ticketRepo.GetOne(id);
        }

        /// <summary>
        /// Modifying venue by id.
        /// </summary>
        /// <param name="id">The id to join. </param>
        /// <param name="venue">The venue is joining.</param>
        public void Modify(int id, int venue)
        {
            this.ticketRepo.Modify(id, venue);
        }

        /// <summary>
        /// Removing number of ticket.
        /// </summary>
        /// <param name="number">The id to join. </param>
        public void Remove(int number)
        {
            this.ticketRepo.Remove(number);
        }
    }
}
