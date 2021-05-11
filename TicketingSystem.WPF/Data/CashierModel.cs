// <copyright file="CashierModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;
    using TicketingSystem.Data.CodeFirstDB;

    /// <summary>Cashier class. </summary>
    public class CashierModel : ObservableObject
    {
         private int id;
         private string name;
         private string address;
         private string cardType;
         private string insurance;
         private int salary;

        /// <summary>Gets or sets sets the cashier name.</summary>
         public int Id
         {
            get { return this.id; }
            set { this.Set(ref this.id, value); }
         }

        /// <summary>Gets or sets the cashier name.</summary>
         public string Name
         {
            get { return this.name; }
            set { this.Set(ref this.name, value); }
         }

        /// <summary>Gets or sets the cashier name.</summary>
         public string Address
         {
            get { return this.address; }
            set { this.Set(ref this.address, value); }
         }

        /// <summary>Gets or sets the cashier name.</summary>
         public string CardType
         {
            get { return this.cardType; }
            set { this.Set(ref this.cardType, value); }
         }

        /// <summary>Gets or sets the cashier name.</summary>
         public string Insurance
         {
           get { return this.insurance; }
           set { this.Set(ref this.insurance, value); }
         }

        /// <summary>Gets or sets the cashier name.</summary>
         public int Salary
         {
          get { return this.salary; }
          set { this.Set(ref this.salary, value); }
         }

        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <param name="other">The id to join.</param>
         public void CopyFrom(CashierModel other)
         {
            if (other != null)
            {
                this.GetType().GetProperties().ToList().
                    ForEach(property => property.SetValue(this, property.GetValue(other)));
            }
         }

        /// <summary>
        /// Method for increasing salary.
        /// </summary>
        /// <returns>Returns string.</returns>
         public override string ToString()
         {
            return base.ToString();
         }
    }
}
