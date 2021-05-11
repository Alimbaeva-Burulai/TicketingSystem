// <copyright file="CashierListViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// This class CashierListViewModel.
    /// </summary>
    public class CashierListViewModel
    {
        /// <summary>Gets or sets the edited cashier.</summary>
        public Cashier EditedCashier { get; set; }

        /// <summary>Gets or sets the list of cashiers.</summary>
        public List<Cashier> ListOfCashiers { get; set; }
    }
}
