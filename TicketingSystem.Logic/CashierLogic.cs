// <copyright file="CashierLogic.cs" company="PlaceholderCompany">
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
    /// This class cashierLogic.
    /// </summary>
    public class CashierLogic : ICashierLogic
    {
        /// <summary>
        /// readonly filed for cashierRepo.
        /// </summary>
        private readonly ICashierRepository cashierRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CashierLogic"/> class.
        /// Constructor for the cachierLogic.
        /// </summary>
        /// <param name="cashierRepo">The id to join.</param>
        public CashierLogic(ICashierRepository cashierRepo)
        {
            this.cashierRepo = cashierRepo;
        }

        /// <summary>
        /// Collection of cashier method.
        /// </summary>
        /// <returns>Returns IList .</returns>
        public IList<Cashier> AllCashier()
        {
            return this.cashierRepo.GetAll().ToList();
        }

        /// <summary>
        /// Mthod for the getting salary averages.
        /// </summary>
        /// <returns>Returns IList.</returns>
        public IList<AveragesResult> GetSalaryAverages()
        {
            var q = from cashier in this.cashierRepo.GetAll()
                   group cashier by new { cashier.CashierId, cashier.CashierName } into grp
                   select new AveragesResult()
                   {
                        CashierName = grp.Key.CashierName,

                        AverageSalary = grp.Average(x => x.Salary),
                   };
            return q.ToList();
        }

        /// <summary>
        /// This is async version of GetSalaryAverages.
        /// </summary>
        /// <returns>It returns a task. </returns>
        public Task<IList<AveragesResult>> GetSalaryAveagesAsync()
        {
            return Task.Run(this.GetSalaryAverages);
        }

        /// <summary>
        /// Mehod for the Increasing cashier salary.
        /// </summary>
        /// <param name="cashierId">The id to join.</param>
        /// <param name="salary">The salary to join.</param>
        public void IncreaseCashierSalary(int cashierId, int salary)
        {
            this.cashierRepo.IncreasingSalary(cashierId, salary);
        }

        /// <summary>
        /// Adding new cashier name.
        /// </summary>
        /// <param name="name">The id to join.</param>
        /// <param name="address">The address to join.</param>
        /// <param name="bankAccount">The bankAccount is to join.</param>
        /// <param name="insurance">The insurance is to join.</param>
        /// <param name="salary">The salary is to join.</param>
        /// <returns>Returns newCashier.</returns>
        public Cashier Add(string name, string address, string bankAccount, string insurance, int salary)
        {
            Cashier newCashier = new Cashier()
            {
                CashierName = name,
                Address = address,
                BankAccount = bankAccount,
                Insurance = insurance,
                Salary = salary,
            };
            this.cashierRepo.Add(newCashier);
            return newCashier;
        }

        /// <summary>
        /// Getting one cashier.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>Returns Cashier.</returns>
        public Cashier OneCashier(int id)
        {
            return this.cashierRepo.GetOne(id);
        }

        /// <summary>
        /// Removing the cashier name.
        /// </summary>
        /// <param name="id">The id to join.</param>
        public void Remove(int id)
        {
            Cashier cashier = this.cashierRepo.GetOne(id);
            if (cashier == null)
            {
                throw new InvalidOperationException("Sorry, the value cannot be null");

                // this.cashierRepo.Remove(id);
            }
            else
            {
                this.cashierRepo.Remove(id);
            }
        }

        /// <summary>
        /// Modifying salary by id.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="cashier">The salary to join.</param>
        public void Modify(int id, Cashier cashier)
        {
            if (cashier != null)
            {
                this.cashierRepo.Modify(id, cashier);
            }
        }

        /// <summary>
        /// Method for the sum of salary.
        /// </summary>
        /// <returns>Returns IList.</returns>
        public IList<AveragesResult> GetSalarySum()
        {
            var q = from cashier in this.cashierRepo.GetAll()
                    group cashier by new { cashier.CashierId, cashier.CashierName } into grp
                    select new AveragesResult()
                    {
                        CashierName = grp.Key.CashierName,

                        AverageSalary = grp.Sum(x => x.Salary),
                    };
            return q.ToList();
        }

        /// <summary>
        /// This is async version of GetSalaryAverages.
        /// </summary>
        /// <returns>It returns a task. </returns>
        public Task<IList<AveragesResult>> GetSalarySumAsync()
        {
            return Task.Run(this.GetSalarySum);
        }

        /// <summary>
        /// Removes a specific entry from the database.
        /// </summary>
        /// <param name="id">ID of the entry.</param>
        /// <returns>Returns bool.</returns>
        bool ICashierLogic.Remove(int id)
        {
            return this.cashierRepo.RemoveCashier(id);
        }

        /// <summary>
        /// Modifying name.
        /// </summary>
        /// <param name="name">The name to join.</param>
        /// <param name="address">The address to join.</param>
        /// <param name="bankAccount">The bankAccount to join.</param>
        /// <param name="salary">The salary to join.</param>
        /// <param name="insurance">The insurance to join.</param>
        public void AddCashier(string name, string address, string bankAccount, int salary, string insurance)
        {
            Cashier newCashier = new Cashier()
            {
                CashierName = name,
                Address = address,
                BankAccount = bankAccount,
                Insurance = insurance,
                Salary = salary,
            };
            this.cashierRepo.Add(newCashier);
        }

        /// <summary>
        /// Removes a specific entry from the database.
        /// </summary>
        /// <param name="id">ID of the entry.</param>
        /// <param name="name">Name of the entry.</param>
        /// <param name="address">Address of the entry.</param>
        /// <param name="bankAccount">BankAccount of the entry.</param>
        /// <param name="salary">Salary of the entry.</param>
        /// <param name="insurance">Insurances of the entry.</param>
        /// <returns>Returns bool.</returns>
        public bool ChangeCashier(int id, string name, string address, string bankAccount, int salary, string insurance)
        {
            Cashier cashier = new Cashier()
            {
                CashierId = id,
                CashierName = name,
                Address = address,
                BankAccount = bankAccount,
                Salary = salary,
                Insurance = insurance,
            };

            return this.cashierRepo.ModifyCashier(id, cashier);
        }
    }
}
