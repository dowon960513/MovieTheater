namespace ProjectTeam08MovieTheater.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieTicketEntities : DbContext
    {
        public MovieTicketEntities()
            : base("name=MovieTicketEntities")
        {
        }

        public virtual DbSet<Auditorium> Auditorium { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Time> Time { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auditorium>()
                .Property(e => e.AudiName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustFirstname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustLastname)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.MoviePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieRate)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieGenre)
                .IsUnicode(false);
        }
    }
}
