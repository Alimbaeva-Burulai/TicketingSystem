// <copyright file="HomeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using TicketingSystem.Web.Models;

    /// <summary>
    /// This class  HomeController.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger is to join.</param>
        public HomeController(ILogger<HomeController> logger)
        {
            this._logger = logger;
        }

        /// <summary>
        /// Index method.
        /// </summary>
        /// <returns>Returns IActionResult .</returns>
        public IActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Privacy method.
        /// </summary>
        /// <returns>Returns IActionResult .</returns>
        public IActionResult Privacy()
        {
            return this.View();
        }

        /// <summary>
        /// Error method.
        /// </summary>
        /// <returns>Returns IActionResult .</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
