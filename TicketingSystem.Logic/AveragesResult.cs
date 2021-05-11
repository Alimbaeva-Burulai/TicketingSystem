// <copyright file="AveragesResult.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.Logic
{
    using System;

    /// <summary>
    /// This class AverageResult.
    /// </summary>
    public class AveragesResult
    {
        /// <summary>Gets or sets the age of customer.</summary>
        public int CustomerAge { get; set; }

        /// <summary>Gets or sets the discounted ticket price.</summary>
        public double DiscountedTicketPrice { get; set; }

        /// <summary>Gets or sets the name of cashier.</summary>
        public string CashierName { get; set; }

        /// <summary>Gets or sets the average salary.</summary>
        public double AverageSalary { get; set; }

        /// <summary>Gets or sets the sum of salary.</summary>
        public double SumOfSalary { get; set; }

        /// <summary>
        /// Mthod ToString.
        /// </summary>
        /// <returns>Returns the string.</returns>
        public override string ToString()
        {
            return $"Customer age :{this.CustomerAge}, discounted price :{this.DiscountedTicketPrice}";
        }

        /// <summary>
        /// Checking if this objects are equal to other .
        /// </summary>
        /// <param name="obj">The entity to join.</param>
        /// <returns>true or false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is AveragesResult)
            {
                AveragesResult other = obj as AveragesResult;
                return (this.CustomerAge == other.CustomerAge && this.DiscountedTicketPrice == other.DiscountedTicketPrice) ||
                       (this.CashierName == other.CashierName && this.AverageSalary == other.AverageSalary && this.SumOfSalary == other.SumOfSalary);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Getting the hashcode.
        /// </summary>
        /// <returns>Returns the number.</returns>
        public override int GetHashCode()
        {
            return this.CustomerAge.GetHashCode() + (int)this.DiscountedTicketPrice;
        }
    }
}
