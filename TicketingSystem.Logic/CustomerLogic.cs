// <copyright file="CustomerLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TicketingSystem.Data.CodeFirstDB;
    using TicketingSystem.Repository;

    /// <summary>
    /// This class CustomerLogic.
    /// </summary>
    public class CustomerLogic : ICustomerLogic
    {
        /// <summary>
        /// Readonly filed for the customerRepo.
        /// </summary>
        private readonly ICustomerRepository customerRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerLogic"/> class.
        /// Constructor of CustomerLogic.
        /// </summary>
        /// <param name="customerRepo">The id to join.</param>
        /// <returns>The joined names will be removed.</returns>
        public CustomerLogic(ICustomerRepository customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        /// <summary>
        /// Adding new field.
        /// </summary>
        /// <param name="name">The id to join.</param>
        public void Add(string name)
        {
            this.customerRepo.Add(name);
        }

        /// <summary>
        /// Method for getting all customers.
        /// </summary>
        /// <returns>Returns IList.</returns>
        public IList<Customer> AllCustomers()
        {
            return this.customerRepo.GetAll().ToList();
        }

        /// <summary>
        /// Method for the changing price.
        /// </summary>
        /// <param name="customerId">The id to join.</param>
        /// <param name="price">The price to join.</param>
        public void ChangePrice(int customerId, int price)
        {
           this.customerRepo.ChangePriceOfTicket(customerId, price);
        }

        /// <summary>
        /// This is GetTicketPriceAverages method.
        /// </summary>
        /// <returns>Returns IList.</returns>
        public IList<AveragesResult> GetTicketPriceAverages()
        {
            var q = from customer in this.customerRepo.GetAll()
                    group customer by new { customer.CustomerID, customer.Age } into grp
                    select new AveragesResult()
                    {
                        CustomerAge = grp.Key.Age,

                        DiscountedTicketPrice = grp.Average(x => x.PriceOfTicket),
                    };
            return q.ToList();
        }

        /// <summary>
        /// This is async version of GetTicketPriceAverages method.
        /// </summary>
        /// <returns>Returns Task.</returns>
        public Task<IList<AveragesResult>> GetTicketPriceAveragesAsync()
        {
            return Task.Run(this.GetTicketPriceAverages);
        }

        /// <summary>
        /// Modifying the price of ticket by id.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="priceOfTicket">The price to join.</param>
        public void Modify(int id, int priceOfTicket)
        {
            this.customerRepo.Modify(id, priceOfTicket);
        }

        /// <summary>
        /// Method for getting one customer.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns customer.</returns>
        public Customer OneCustomer(int id)
        {
            return this.customerRepo.GetOne(id);
        }

        /// <summary>
        /// Removing name of customer.
        /// </summary>
        /// <param name="name">The id to join.</param>
        public void Remove(string name)
        {
            this.customerRepo.Remove(name);
        }
    }
}
