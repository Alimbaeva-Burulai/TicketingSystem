// <copyright file="GlobalSuppressions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:Field names should not begin with underscore", Justification = "<Nikgitstats>", Scope = "member", Target = "~F:TicketingSystem.Web.Controllers.HomeController._logger")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "<NikGitstats>", Scope = "member", Target = "~M:TicketingSystem.Web.Controllers.CashiersController.Index~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("Design", "CA1002:Do not expose generic lists", Justification = "<NikGitstats>", Scope = "member", Target = "~P:TicketingSystem.Web.Models.CashierListViewModel.ListOfCashiers")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "<NikGitstats>", Scope = "type", Target = "~T:TicketingSystem.Web.Models.MapperFactory")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<NikGitstats>", Scope = "member", Target = "~M:TicketingSystem.Web.Controllers.CashiersController.#ctor(TicketingSystem.Logic.ICashierLogic,AutoMapper.IMapper)")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<NikGitstats>", Scope = "member", Target = "~P:TicketingSystem.Web.Models.CashierListViewModel.ListOfCashiers")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "<NikGitstats>", Scope = "type", Target = "~T:TicketingSystem.Web.Program")]
