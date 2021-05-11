// <copyright file="ICashierLogic.cs" company="PlaceholderCompany">
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
    public interface ICashierLogic
    {
        /// <summary>
        /// Method for getting one cashier.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <returns>returns cashier.</returns>
        Cashier OneCashier(int id);

        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <param name="cashierId">The id to join.</param>
        /// <param name="salary">The salary to join.</param>
        void IncreaseCashierSalary(int cashierId, int salary);

        /// <summary>
        /// Method for the all Cashier.
        /// </summary>
        /// <returns>Returns IList.</returns>
        IList<Cashier> AllCashier();

        /// <summary>
        /// Method for getting average of salary.
        /// </summary>
        /// <returns>Returns the IList.</returns>
        IList<AveragesResult> GetSalaryAverages();

        /// <summary>
        /// Removes a specific entry from the database.
        /// </summary>
        /// <param name="id">ID of the entry.</param>
        /// <returns>Returns bool.</returns>
        bool Remove(int id);

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
        bool ChangeCashier(int id, string name, string address, string bankAccount, int salary, string insurance);

        /// <summary>
        /// Modifying name.
        /// </summary>
        /// <param name="id">The id to join.</param>
        /// <param name="cashier">The salary to join.</param>
        void Modify(int id, Cashier cashier);

        /// <summary>
        /// Method for getting sum of salary.
        /// </summary>
        /// <returns>Returns the IList.</returns>
        IList<AveragesResult> GetSalarySum();

        /// <summary>
        /// Modifying name.
        /// </summary>
        /// <param name="name">The name to join.</param>
        /// <param name="address">The address to join.</param>
        /// <param name="bankAccount">The bankAccount to join.</param>
        /// <param name="salary">The salary to join.</param>
        /// <param name="insurance">The insurance to join.</param>
        void AddCashier(string name, string address, string bankAccount, int salary, string insurance);
    }
}
