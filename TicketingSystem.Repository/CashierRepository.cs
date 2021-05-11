// <copyright file="CashierRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using TicketingSystem.Data.CodeFirstDB;

    /// <summary>
    /// This class CashierRepository.
    /// </summary>
    public class CashierRepository : RepositoryBase<Cashier>, ICashierRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashierRepository"/> class.
        /// Constructor for CashierRepository.
        /// </summary>
        /// <param name="ctx">The id to join.</param>
        public CashierRepository(DbContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc/>
        public void Add(Cashier entry)
        {
                this.Ctx.Set<Cashier>().Add(entry);
                this.Ctx.SaveChanges();
        }

        /// <inheritdoc/>
        public override Cashier GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.CashierId == id);
        }

        /// <inheritdoc/>
        public void IncreasingSalary(int id, int newSalary)
        {
            var cashier = this.GetOne(id);
            if (cashier == null)
            {
                throw new InvalidOperationException("Cashier is not found");
            }

            cashier.Salary = newSalary;
            this.Ctx.SaveChanges();
        }

        /// <inheritdoc/>
        public void Modify(int id, Cashier cashier)
        {
            if (cashier != null)
            {
                this.GetOne(id).CashierName = cashier.CashierName;
                this.GetOne(id).Address = cashier.Address;
                this.GetOne(id).BankAccount = cashier.BankAccount;
                this.GetOne(id).Insurance = cashier.Insurance;
                this.GetOne(id).Salary = cashier.Salary;
                this.Ctx.SaveChanges();
            }
        }

        /// <inheritdoc/>
        public bool ModifyCashier(int id, Cashier cashier)
        {
            if (cashier == null)
            {
               return false;
            }
            else
            {
                this.GetOne(id).CashierName = cashier.CashierName;
                this.GetOne(id).Address = cashier.Address;
                this.GetOne(id).BankAccount = cashier.BankAccount;
                this.GetOne(id).Insurance = cashier.Insurance;
                this.GetOne(id).Salary = cashier.Salary;
                this.Ctx.SaveChanges();
                return true;
            }
        }

        /// <inheritdoc/>
        public void Remove(int id)
        {
            Cashier cashier = new Cashier();
            cashier = this.GetOne(id);
            this.Ctx.Set<Cashier>().Remove(cashier);
            this.Ctx.SaveChanges();
        }

        /// <inheritdoc/>
        public bool RemoveCashier(int id)
        {
            Cashier cashier = new Cashier();
            cashier = this.GetOne(id);
            this.Ctx.Set<Cashier>().Remove(cashier);
            this.Ctx.SaveChanges();
            return true;
        }
    }
}
