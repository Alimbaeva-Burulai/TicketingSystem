using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketingSystem.Data.CodeFirstDB
{/// <summary> bookingticket class. </summary>
    [Table("tickets")]
    public class BookingTicket
    {
        /// <summary>Gets or sets the id.</summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }

        /// <summary>Gets or sets the datetime.</summary>
        [MaxLength(100)]
        public string DateTime { get; set; }

        /// <summary>Gets or sets the ticketvenue.</summary>
        public int TicketVenue { get; set; }

        /// <summary>Gets or sets the ticketnumber.</summary>
        public int TicketNumber { get; set; }

        /// <summary>Gets or sets the id of customer.</summary>
        [ForeignKey(nameof(CodeFirstDB.Customer))]
        public int CustomerId { get; set; }

        /// <summary>Gets or sets the id of cashier.</summary>
        [ForeignKey(nameof(Cashier))]
        public int CashierId { get; set; }

        /// <summary>Gets or sets the id of movie.</summary>
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        /// <summary>Gets or sets the customer.</summary>
        [NotMapped]
        public virtual Customer Customer { get; set; }

        /// <summary>Gets or sets the cashier.</summary>
        public virtual Cashier Cashier { get; set; }

        /// <summary>Gets or sets the movie.</summary>
        public virtual Movie Movie { get; set; }
    }
}
