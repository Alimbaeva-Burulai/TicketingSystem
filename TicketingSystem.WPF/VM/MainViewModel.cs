// <copyright file="MainViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.VM
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using CommonServiceLocator;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using TicketingSystem.WPF.BL;
    using TicketingSystem.WPF.Data;

    /// <summary>CashierLogic class.</summary>
    internal class MainViewModel : ViewModelBase
    {
        private ICashierLogic logic;
        private CashierModel cashierSelected;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="logic">This is parameter.</param>
        public MainViewModel(ICashierLogic logic)
        {
            this.logic = logic;

            this.GroupOfCashier = new ObservableCollection<CashierModel>(); // logic.GetAllCashiers()

            if (this.IsInDesignMode)
            {
                CashierModel c2 = new CashierModel() { Name = "Mary", Salary = 200000, Insurance = "Exists", Address = "Csengery 66", CardType = "Mastercard" };
                CashierModel c3 = new CashierModel() { Name = "Anna", Salary = 100000, Insurance = "no", CardType = "Visa", Address = "Bertalan 44" };
                this.GroupOfCashier.Add(c2);
                this.GroupOfCashier.Add(c3);
            }
            else
            {
                IList<CashierModel> list = this.logic.GetAllCashiers();
                foreach (var item in list)
                {
                    this.GroupOfCashier.Add(item);
                }
            }

            this.AddCmd = new RelayCommand(() => this.logic.AddCashier(this.GroupOfCashier));

            this.ModCmd = new RelayCommand(() => this.logic.ModCashier(this.CashierSelected));

            this.DelCmd = new RelayCommand(() => this.logic.DelCashier(this.GroupOfCashier, this.CashierSelected));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
            : this(IsInDesignModeStatic ? null : ServiceLocator.Current.GetInstance<ICashierLogic>())
            {
            }

        /// <summary>Gets or sets the cashierSelected.</summary>
        public CashierModel CashierSelected
        {
            get { return this.cashierSelected; }
            set { this.Set(ref this.cashierSelected, value); }
        }

        /// <summary>Gets the group of cashier.</summary>
        public ObservableCollection<CashierModel> GroupOfCashier { get; private set; }

        /// <summary>Gets the Add command.</summary>
        public ICommand AddCmd { get; private set; }

        /// <summary>Gets Modify command.</summary>
        public ICommand ModCmd { get; private set; }

        /// <summary>Gets the Delete command.</summary>
        public ICommand DelCmd { get; private set; }
    }
}
