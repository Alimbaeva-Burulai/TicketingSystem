// <copyright file="CashierLogic2.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight.Messaging;
    using TicketingSystem.Data.CodeFirstDB;
    using TicketingSystem.Logic;
    using TicketingSystem.WPF.Data;

    /// <summary>CashierLogic class. </summary>
    public class CashierLogic2 : ICashierLogic
     {
        private IEditorService editorService;
        private IMessenger messengerService;
        private Workers cashiers;

        /// <summary>
        /// Initializes a new instance of the <see cref="CashierLogic2"/> class.
        /// The class constructor.
        /// </summary>
        /// <param name="service">The interface to join.</param>
        /// <param name="messenger">The id to join.</param>
        /// <param name="cashiers">The parameter is Cashiers object.</param>
        public CashierLogic2(IEditorService service, IMessenger messenger, Workers cashiers)
        {
            this.editorService = service;
            this.messengerService = messenger;
            this.cashiers = cashiers;
        }

        /// <summary>
        /// Method for getting one cashier.
        /// </summary>
        /// <param name="list">The id to join.</param>
        public void AddCashier(IList<CashierModel> list)
        {
            CashierModel newCashier = new CashierModel();
            if (this.editorService.EditCashier(newCashier) == true)
            {
                newCashier.Id = this.cashiers.CashierLogic.Add(newCashier.Name, newCashier.Address, newCashier.CardType, newCashier.Insurance, newCashier.Salary).CashierId;
                list.Add(newCashier);
                this.messengerService.Send("ADD OK", "LogicResult");
            }
            else
            {
                this.messengerService.Send("ADD CANCEL", "LogicalResult");
            }
        }

        /// <summary>
        /// Joins a first name and a last name together into a single string.
        /// </summary>
        /// <param name="list">Part of the name.</param>
        /// <param name="cashier">Cashier.</param>
        public void DelCashier(IList<CashierModel> list, CashierModel cashier)
        {
            if (cashier != null && list.Remove(cashier))
            {
                this.cashiers.CashierLogic.Remove(cashier.Id);
                this.messengerService.Send("DELETE OK", "LogicResult");
            }
            else
            {
                this.messengerService.Send("DELETE FAILED", "LogicResult");
            }
        }

        /// <summary>
        /// This is GetAllCashiers() method.
        /// </summary>
        /// <returns> Returns IList of CashierModel.</returns>
        public IList<CashierModel> GetAllCashiers()
        {
            IList<CashierModel> list = new List<CashierModel>();
            IList<Cashier> cashierList = this.cashiers.CashierLogic.AllCashier();
            foreach (var item in cashierList)
            {
                CashierModel cashierModel = new CashierModel();
                cashierModel.Id = item.CashierId;
                cashierModel.Name = item.CashierName;
                cashierModel.Address = item.Address;
                cashierModel.CardType = item.BankAccount;
                cashierModel.Insurance = item.Insurance;
                cashierModel.Salary = item.Salary;

                list.Add(cashierModel);
            }

            return list;
        }

        /// <summary>
        /// Method for getting one cashier.
        /// </summary>
        /// <param name="cashierToModify">The id to join.</param>
        public void ModCashier(CashierModel cashierToModify)
        {
            if (cashierToModify == null)
            {
                this.messengerService.Send("EDIT FAILED", "LogicResilt");
                return;
            }

            CashierModel clone = new CashierModel();
            clone.CopyFrom(cashierToModify);
            if (this.editorService.EditCashier(clone) == true)
            {
                cashierToModify.CopyFrom(clone);

                Cashier cashier = new Cashier();
                cashier.CashierId = cashierToModify.Id;
                cashier.CashierName = cashierToModify.Name;
                cashier.Address = cashierToModify.Address;
                cashier.BankAccount = cashierToModify.CardType;
                cashier.Insurance = cashierToModify.Insurance;
                cashier.Salary = cashierToModify.Salary;
                this.cashiers.CashierLogic.Modify(cashierToModify.Id, cashier);
                this.messengerService.Send("EDIT OK", "LogicResult");
            }
            else
            {
                this.messengerService.Send("EDIT CANCEL", "LogicRessult");
            }
        }
    }
}
