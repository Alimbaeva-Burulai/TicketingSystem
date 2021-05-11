// <copyright file="CashiersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using TicketingSystem.Logic;
    using TicketingSystem.Web.Models;

    /// <summary>
    /// This class CashiersController.
    /// </summary>
    public class CashiersController : Controller
    {
        private ICashierLogic logic;
        private IMapper mapper;
        private CashierListViewModel vm;

        /// <summary>
        /// Initializes a new instance of the <see cref="CashiersController"/> class.
        /// </summary>
        /// <param name="logic">The logic of CashiersController.</param>
        /// <param name="mapper">The mapper of CashiersController.</param>
        public CashiersController(ICashierLogic logic, IMapper mapper)
        {
            this.logic = logic;
            this.mapper = mapper;

            this.vm = new CashierListViewModel();
            this.vm.EditedCashier = new Models.Cashier();

            var cashiers = logic.AllCashier();
            this.vm.ListOfCashiers = mapper.Map<IList<Data.CodeFirstDB.Cashier>, List<Models.Cashier>>(cashiers);
        }

        private Models.Cashier GetCashierModel(int id)
        {
            Data.CodeFirstDB.Cashier oneCashier = this.logic.OneCashier(id);
            return this.mapper.Map<Data.CodeFirstDB.Cashier, Models.Cashier>(oneCashier);
        }

        // Gets : Cashiers

        /// <summary>
        /// Collection of cashier method.
        /// </summary>
        /// <returns>Returns IActionResult  .</returns>
        public IActionResult Index()
        {
            this.ViewData["editAction"] = "AddNew";
            return this.View("CashiersIndex", this.vm);
        }

        // Gets : Cashiers/Details/5

        /// <summary>
        /// Details method.
        /// </summary>
        /// <param name="id">The id is to join.</param>
        /// <returns>Returns IActionResult .</returns>
        public IActionResult Details(int id)
        {
            return this.View("CashiersDetails", this.GetCashierModel(id));
        }

        // Gets : Cashiers/Remove/5

        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="id">The id is to join.</param>
        /// <returns>Returns IActionResult .</returns>
        public IActionResult Remove(int id)
        {
            this.TempData["editResult"] = "Delete FAIL";
            if (this.logic.Remove(id))
            {
                this.TempData["editResult"] = "Delete OK";
            }

            return this.RedirectToAction(nameof(this.Index));
        }

        // Gets : Cashiers/Details/5

        /// <summary>
        /// Edit method.
        /// </summary>
        /// <param name="id">The id is to join.</param>
        /// <returns>Returns IActionResult .</returns>
        public IActionResult Edit(int id)
        {
            this.ViewData["editAction"] = "Edit";
            this.vm.EditedCashier = this.GetCashierModel(id);
            return this.View("CashiersIndex", this.vm);
        }

        // POST Cashiers/Edit + receive one cashier + receive editAction

        /// <summary>
        /// Edit method.
        /// </summary>
        /// <param name="cashier">The cashier is to join.</param>
        /// <param name="editAction">The editAction is to join.</param>
        /// <returns>Returns IActionResult .</returns>
        [HttpPost]
        public IActionResult Edit(Models.Cashier cashier, string editAction)
        {
            if (this.ModelState.IsValid && cashier != null)
            {
                this.TempData["editResult"] = "Edit FAIL";
                if (editAction == "AddNew")
                {
                    try
                    {
                        this.logic.AddCashier(cashier.Name, cashier.Address, cashier.BankAccount, cashier.Salary, cashier.Insurance);
                        this.TempData["editResult"] = "Adding OK";
                    }
                    catch (ArgumentException)
                    {
                    }
                }
                else
                {
                    if (this.logic.ChangeCashier(cashier.Id, cashier.Name, cashier.Address, cashier.BankAccount, cashier.Salary, cashier.Insurance))
                    {
                        this.TempData["editResult"] = "Edit OK";
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }
            else
            {
                this.ViewData["editAction"] = "Edit";
                this.vm.EditedCashier = cashier;
                return this.View("CashiersIndex", this.vm);
            }
        }
    }
}
