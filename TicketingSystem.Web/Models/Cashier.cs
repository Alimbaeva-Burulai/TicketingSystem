// <copyright file="Cashier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    // Form Model / MVC ViewModel

    /// <summary>
    /// This class cashiers.
    /// </summary>
    public class Cashier
    {
        /// <summary>Gets or sets the id of cashier.</summary>
        [Display(Name="Cashier id")]
        [Required]
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        [Display(Name = "Cashier name")]
        [Required]
        [StringLength(30, MinimumLength =5)]
        public string Name { get; set; }

        /// <summary>Gets or sets the Address.</summary>
        [Display(Name = "Cashier address")]
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Address { get; set; }

        /// <summary>Gets or sets the BankAccount.</summary>
        [Display(Name = "Cashier bank account")]
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string BankAccount { get; set; }

        /// <summary>Gets or sets the salary.</summary>
        [Display(Name = "Cashier salary")]
        [Required]
        public int Salary { get; set; }

        /// <summary>Gets or sets the insurance.</summary>
        [Display(Name = "Cashier insurance")]
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Insurance { get; set; }
    }
}
