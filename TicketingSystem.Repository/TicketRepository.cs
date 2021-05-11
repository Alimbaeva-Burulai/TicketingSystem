// <copyright file="TicketRepository.cs" company="PlaceholderCompany">
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
    /// This class performs an important function.
    /// </summary>
    public class TicketRepository : RepositoryBase<BookingTicket>, ITicketRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketRepository"/> class.
        /// Constructor TicketRepository.
        /// </summary>
        /// <param name="ctx">The id to join.</param>
        /// <returns>The joined names will be removed.</returns>
        public TicketRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc/>
        public int Add(int number)
        {
            BookingTicket ticket = new BookingTicket();
            ticket.TicketNumber = number;
            this.Ctx.Set<BookingTicket>().Add(ticket);
            this.Ctx.SaveChanges();
            return ticket.TicketId;
        }

        /// <inheritdoc/>
        public void ChangeVenue(int id, int newVenue)
        {
            var ticket = this.GetOne(id);
            if (ticket == null)
            {
                throw new InvalidOperationException("Ticket is not found");
            }

            ticket.TicketVenue = newVenue;
            this.Ctx.SaveChanges();
        }

        /// <inheritdoc/>
        public override BookingTicket GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.TicketId == id);
        }

        /// <inheritdoc/>
        public void Modify(int id, int venue)
        {
            BookingTicket ticket = new BookingTicket();
            this.Ctx.Set<BookingTicket>().Where(x => x.TicketId == id).First().TicketVenue = venue;
        }

        /// <inheritdoc/>
        public int Remove(int number)
        {
            BookingTicket ticket = new BookingTicket();
            ticket.TicketNumber = number;
            this.Ctx.Set<BookingTicket>().Add(ticket);
            this.Ctx.SaveChanges();
            return ticket.TicketId;
        }
    }
}
