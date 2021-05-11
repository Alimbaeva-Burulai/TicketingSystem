using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketingSystem.Data.CodeFirstDB
{
    /// <summary>Represents a mutable string of characters. </summary>
    [Table("conn_cashier_customer")]
    public class ConnCashierCustomer
    {
        /// <summary> Gets or sets the connid.</summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConnId { get; set; }

        /// <summary>Gets or sets the id of customer.</summary>
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        /// <summary>Gets or sets the id of cashier.</summary>
        [ForeignKey(nameof(Cashier))]
        public int CashierId { get; set; }

        /// <summary>Gets or sets the customer.</summary>
        [NotMapped]
        public virtual Customer Customer { get; set; }

        /// <summary>Gets or sets the cashier.</summary>
        [NotMapped]
        public virtual Cashier Cashier { get; set; }
    }
}
