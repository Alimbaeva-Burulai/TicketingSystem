// <copyright file="ErrorViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Web.Models
{
    using System;

    /// <summary>
    /// This class cashierLogic.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>Gets or sets the id of Request.</summary>
        public string RequestId { get; set; }

        /// <summary>Gets a value  indicating whether.</summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}
