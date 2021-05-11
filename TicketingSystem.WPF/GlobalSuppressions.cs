// <copyright file="GlobalSuppressions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1115:Parameter should follow comma", Justification = "<NikGitStats>")]

// [assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:Prefix local calls with this", Justification = "<NikGitStats>", Scope = "module", Target = "~M:TicketingSystem.WPF.MainWindow.#ctor")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "<NikGitStats>", Scope = "member", Target = "~M:TicketingSystem.WPF.VM.MainViewModel.#ctor(TicketingSystem.WPF.BL.ICashierLogic)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<NikGitStats>", Scope = "member", Target = "~M:TicketingSystem.WPF.BL.CashierLogic2.ModCashier(TicketingSystem.WPF.Data.CashierModel)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<NikGitStats>", Scope = "member", Target = "~M:TicketingSystem.WPF.BL.CashierLogic2.AddCashier(System.Collections.Generic.IList{TicketingSystem.WPF.Data.CashierModel})")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<NikGitStats>", Scope = "member", Target = "~M:TicketingSystem.WPF.BL.CashierLogic2.DelCashier(System.Collections.Generic.IList{TicketingSystem.WPF.Data.CashierModel},TicketingSystem.WPF.Data.CashierModel)")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "<NikGitStats>", Scope = "type", Target = "~T:TicketingSystem.WPF.BL.Workers")]
[assembly: SuppressMessage("Build", "CA1812", Justification = "<NikGitStats>")]