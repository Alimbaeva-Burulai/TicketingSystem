// <copyright file="ICashierLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TicketingSystem.Logic;
    using TicketingSystem.WPF.Data;

    /// <summary>
    /// Documentation that describes the interface goes here.
    /// </summary>
    internal interface ICashierLogic
    {
        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <param name="list">The id to join.</param>
        void AddCashier(IList<CashierModel> list);

        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <param name="cashierToModify">The id to join.</param>
        void ModCashier(CashierModel cashierToModify);

        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <param name="list">The id to join.</param>
        /// <param name="cashier">The salary to join.</param>
        void DelCashier(IList<CashierModel> list, CashierModel cashier);

        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <returns>Returns IList of CashierModel.</returns>
        IList<CashierModel> GetAllCashiers();
    }
}
