// <copyright file="IEditorService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TicketingSystem.WPF.Data;

    /// <summary>
    /// Documentation that describes the interface goes here.
    /// </summary>
    public interface IEditorService
    {
        /// <summary>
        /// Method for getting one cashier.
        /// </summary>
        /// <param name="cashier">The id to join.</param>
        /// <returns>returns cashier.</returns>
        bool EditCashier(CashierModel cashier);
    }
}
