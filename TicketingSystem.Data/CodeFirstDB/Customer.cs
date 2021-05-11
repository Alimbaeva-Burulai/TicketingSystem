using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketingSystem.Data.CodeFirstDB
{
    /// <summary>Customer class. </summary>
    [Table("customer")]
    public class Customer
    {
        /// <summary>Gets or sets the customer.</summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        /// <summary>Gets or sets the name of customer.</summary>
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

       /// <summary>Gets or sets the mobile.</summary>
        public string Mobile { get; set; }

       /// <summary>Gets or sets the age.</summary>
        public int Age { get; set; }

        /// <summary>Gets or sets the address.</summary>
        public string Address { get; set; }

        /// <summary>Gets or sets the price of ticket.</summary>
        public int PriceOfTicket { get; set; }

        /// <summary>Gets the collection of tickets.</summary>
        [NotMapped]
        public virtual ICollection<BookingTicket> Tickets { get; }

        /// <summary>Gets the collection of connections.</summary>
        [NotMapped]
        public virtual ICollection<ConnCashierCustomer> Connections { get; }

        /// <summary>Initializes a new instance of the <see cref="Customer"/> class.</summary>
        public Customer()
        {
            this.Tickets = new HashSet<BookingTicket>();
            this.Connections = new HashSet<ConnCashierCustomer>();
        }
    }
}
