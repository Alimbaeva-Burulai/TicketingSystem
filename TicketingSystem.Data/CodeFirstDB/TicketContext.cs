using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TicketingSystem.Data.CodeFirstDB
{
    /// <summary>
    /// Database entities.
    /// </summary>
    public class TicketContext : DbContext
    {
        /// <summary>Gets or sets the database set of cashier.</summary>
        public DbSet<Cashier> Cashiers { get; set; }

        /// <summary>Gets or sets the database set of movies.</summary>
        public DbSet<Movie> Movies { get; set; }

        /// <summary>Gets or sets the database set of customers.</summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>Gets or sets the database set of tickets.</summary>
        public DbSet<BookingTicket> Tickets { get; set; }

        /// <summary>Gets or sets the database set of connections.</summary>
        public DbSet<ConnCashierCustomer> Connections { get; set; }

        /// <summary>Initializes a new instance of the <see cref="TicketContext"/> class.</summary>
        public TicketContext()
        {
            this.Database.EnsureCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketContext"/> class.
        /// Configuring on sql server.
        /// </summary>
        /// <param name="options">The id to join.</param>
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options)
        {
        }

        // Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Burulai\Documents\oenik_prog3_2020_2f8skrv\TicketingSystem\TicketingSystem.Data\TicketDB.mdf;Integrated Security=True

        /// <summary>
        /// Configuring on sql server.
        /// </summary>
        /// <param name="optionsBuilder">The id to join.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TicketDB.mdf;Integrated Security=True;MultipleActiveResultSets=True");
            }
        }

        /// <summary>
        /// Filling the database with records.
        /// </summary>
        /// <param name="modelBuilder">The id to join.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Cashier cashier = new Cashier() { CashierId = 1, CashierName = "Ben Tenison", Address = "Csengery 84", BankAccount = "Mastercard", Insurance = "Exists ", Salary = 100000 };
            Cashier cashier2 = new Cashier() { CashierId = 2, CashierName = "Mary Johnson", Address = "Raday 97", BankAccount = "Visa", Insurance = "Have ", Salary = 120000 };
            Cashier cashier3 = new Cashier() { CashierId = 3, CashierName = "Alan Will", Address = "Bertalan 88", BankAccount = "-", Insurance = "No ", Salary = 115000 };
            Customer customer = new Customer() { CustomerID = 1, Name = "Bill Willson", Mobile = "+36 89 567 8978", Age = 25, Address = "Istvan 67", PriceOfTicket = 3000 };
            Customer customer2 = new Customer() { CustomerID = 2, Name = "Aiperi Alimbaeva", Mobile = "+996 89 567 8978", Age = 16, Address = "Sputnik 12", PriceOfTicket = 1500 };
            Customer customer3 = new Customer() { CustomerID = 3, Name = "Bekbolsun Botoev", Mobile = "+996 89 569 8978", Age = 10, Address = "Koibagarov 10", PriceOfTicket = 1200 };
            Movie movie = new Movie() { MovieId = 1, MovieName = "Twighlight", Language = "English", Minute = 120, Type = "Fantasy", Date = "2020-12-06" };
            Movie movie2 = new Movie() { MovieId = 2, MovieName = "Peculiar children", Language = "Kyrgyz", Minute = 110, Type = "Fantasy", Date = "2020-12-05" };
            Movie movie3 = new Movie() { MovieId = 3, MovieName = "Education", Language = "Russian", Minute = 120, Type = "Drama", Date = "2020-12-04" };
            BookingTicket ticket = new BookingTicket() { TicketId = 1, CashierId = cashier.CashierId, CustomerId = customer.CustomerID, MovieId = movie.MovieId, DateTime = "2020-12-06 12:00", TicketVenue = 5, TicketNumber = 7 };
            BookingTicket ticket2 = new BookingTicket() { TicketId = 2, CashierId = cashier2.CashierId, CustomerId = customer2.CustomerID, MovieId = movie2.MovieId, DateTime = "2020-12-05 14:00", TicketVenue = 9, TicketNumber = 11 };
            BookingTicket ticket3 = new BookingTicket() { TicketId = 3, CashierId = cashier3.CashierId, CustomerId = customer3.CustomerID, MovieId = movie3.MovieId, DateTime = "2020-12-04 12:00", TicketVenue = 8, TicketNumber = 17 };

            modelBuilder.Entity<BookingTicket>(entity =>
            {
                entity.HasOne(ticket => ticket.Cashier).
                       WithMany(cashier => cashier.Tickets).
                       HasForeignKey(ticket => ticket.CashierId);
                entity.HasOne(ticket => ticket.Customer).
                       WithMany(customer => customer.Tickets).
                       HasForeignKey(ticket => ticket.CustomerId);
                entity.HasOne(ticket => ticket.Movie).
                       WithMany(movie => movie.Tickets).
                       HasForeignKey(ticket => ticket.MovieId);
            });
            modelBuilder.Entity<ConnCashierCustomer>(entity =>
            {
                entity.HasOne(connection => connection.Cashier).
                       WithMany(cashier => cashier.Connections).
                       HasForeignKey(connection => connection.CashierId);
                entity.HasOne(connection => connection.Customer).
                       WithMany(customer => customer.Connections).
                       HasForeignKey(connection => connection.CustomerId);
            });

            modelBuilder.Entity<Cashier>().HasData(cashier, cashier2, cashier3);
            modelBuilder.Entity<Customer>().HasData(customer, customer2, customer3);
            modelBuilder.Entity<Movie>().HasData(movie, movie2, movie3);
            modelBuilder.Entity<BookingTicket>().HasData(ticket, ticket2, ticket3);
        }
    }
}
