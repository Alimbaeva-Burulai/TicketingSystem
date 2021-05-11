// <copyright file="EditorViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.VM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;
    using TicketingSystem.WPF.Data;

    /// <summary> CashierLogic class. </summary>
    internal class EditorViewModel : ViewModelBase
    {
        private CashierModel cashier;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorViewModel"/> class.
        /// </summary>
        public EditorViewModel()
        {
            this.cashier = new CashierModel();
            if (this.IsInDesignMode)
            {
                this.cashier.Name = "Mary";
                this.cashier.Address = "Bertalan 10";
                this.cashier.CardType = "MasterCard";
                this.cashier.Insurance = "Exists";
                this.cashier.Salary = 100000;
            }
        }

        /// <summary>Gets or sets the cashier.</summary>
        public CashierModel Cashier
        {
            get { return this.cashier; }
            set { this.Set(ref this.cashier, value); }
        }
    }
}
