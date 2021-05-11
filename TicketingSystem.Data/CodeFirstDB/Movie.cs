using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketingSystem.Data.CodeFirstDB
{
    /// <summary> Movie class.. </summary>
    [Table("movies")]
    public class Movie
    {
        /// <summary>Gets or sets the movie.</summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        /// <summary>Gets or sets the name of movie.</summary>
        [MaxLength(100)]
        [Required]
        public string MovieName { get; set; }

        /// <summary>Gets or sets the language.</summary>
        public string Language { get; set; }

        /// <summary>Gets or sets the minute.</summary>
        public int Minute { get; set; }

        /// <summary>Gets or sets the type.</summary>
        public string Type { get; set; }

        /// <summary>Gets or sets the date.</summary>
        public string Date { get; set; }

        /// <summary>Gets the collection of tickets.</summary>
        [NotMapped]
        public virtual ICollection<BookingTicket> Tickets { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// The class constructor.
        /// </summary>
        public Movie()
        {
            this.Tickets = new HashSet<BookingTicket>();
        }
    }
}
