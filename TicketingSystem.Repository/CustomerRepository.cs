// <copyright file="CustomerRepository.cs" company="PlaceholderCompany">
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
    /// This class CustomerRepository.
    /// </summary>
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// Constructor for CustomerRepository.
        /// </summary>
        /// <param name="ctx">The id to join.</param>
        public CustomerRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc/>
        public int Add(string name)
        {
            Customer customer = new Customer();
            customer.Name = name;
            this.Ctx.Set<Customer>().Add(customer);
            this.Ctx.SaveChanges();
            return customer.CustomerID;
        }

        /// <inheritdoc/>
        public void ChangePriceOfTicket(int id, int newPrice)
        {
            var customer = this.GetOne(id);
            if (customer == null)
            {
                throw new InvalidOperationException("Customer is not found");
            }

            customer.PriceOfTicket = newPrice;
            this.Ctx.SaveChanges();
        }

        /// <inheritdoc/>
        public override Customer GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.CustomerID == id);
        }

        /// <inheritdoc/>
        public void Modify(int id, int priceOfTicket)
        {
            Customer customer = new Customer();
            this.Ctx.Set<Customer>().Where(x => x.CustomerID == id).First().PriceOfTicket = priceOfTicket;
        }

        /// <inheritdoc/>
        public int Remove(string name)
        {
            Customer customer = new Customer();
            customer.Name = name;
            this.Ctx.Set<Customer>().Remove(customer);
            this.Ctx.SaveChanges();
            return customer.CustomerID;
        }
    }
}
