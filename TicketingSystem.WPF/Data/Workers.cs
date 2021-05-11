// <copyright file="Workers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TicketingSystem.Data.CodeFirstDB;
    using TicketingSystem.Logic;
    using TicketingSystem.Repository;

    /// <summary>
    /// class of Cashiers.
    /// </summary>
    public class Workers
    {
        private TicketContext ctx;
        private CashierRepository cashierRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Workers"/> class.
        /// </summary>
        public Workers()
        {
            this.ctx = new TicketContext();
            this.cashierRepo = new CashierRepository(this.ctx);
            this.CashierLogic = new CashierLogic(this.cashierRepo);
        }

        /// <summary>
        /// Gets the CashierLogic.
        /// </summary>
        public CashierLogic CashierLogic { get; }
    }
}
