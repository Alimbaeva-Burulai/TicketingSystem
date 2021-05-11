using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketingSystem.Data.CodeFirstDB
{
    /// <summary>Cashier class. </summary>
    [Table("cashier")]
    public class Cashier
    {
        /// <summary>Gets or sets the id of cashier.</summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CashierId { get; set; }

        /// <summary>Gets or sets the cashier name.</summary>
        [MaxLength(100)]
        [Required]
        public string CashierName { get; set; }

        /// <summary>Gets or sets the address.</summary>
        public string Address { get; set; }

        /// <summary>Gets or sets the bancaccount.</summary>
        public string BankAccount { get; set; }

        /// <summary>Gets or sets the insurance.</summary>
        public string Insurance { get; set; }

        /// <summary>Gets or sets the salary.</summary>
        public int Salary { get; set; }

        /// <summary>Gets  the collection of tickets.</summary>
        [NotMapped]
        public virtual ICollection<BookingTicket> Tickets { get; }

        /// <summary>Gets the collection of connections.</summary>
        [NotMapped]
        public virtual ICollection<ConnCashierCustomer> Connections { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cashier"/> class.
        /// The class constructor.
        /// </summary>
        public Cashier()
        {
            this.Tickets = new HashSet<BookingTicket>();
            this.Connections = new HashSet<ConnCashierCustomer>();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Id: {this.CashierId}, Name: {this.CashierName}, Address : {this.Address}, BankAccount: {this.BankAccount}, Insurance: {this.Insurance}, Salary: {this.Salary}";
        }
    }
}
