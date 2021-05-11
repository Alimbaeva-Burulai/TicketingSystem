// <copyright file="EditorServiceViaWindow.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TicketingSystem.WPF.BL;
    using TicketingSystem.WPF.Data;

    /// <summary>
    /// This is the EditorServiceViaWindow class.
    /// </summary>
    public class EditorServiceViaWindow : IEditorService
    {
        /// <summary>
        /// Method that checks the editing cashier.
        /// </summary>
        /// <param name="cashier">The id to join.</param>
        /// <returns>returns bool.</returns>
        public bool EditCashier(CashierModel cashier)
        {
            EditorWindow win = new EditorWindow(cashier);
            return win.ShowDialog() ?? false;
        }
    }
}
