namespace LibraryExample.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryExampleEntities : DbContext
    {
        public LibraryExampleEntities()
            : base("name=LibraryExampleEntities")
        {
        }

        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Autor)
                .HasForeignKey(e => e.Autors_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Loans)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.Books_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.Books_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Loans)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Clients_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Clients_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Loan>()
                .HasMany(e => e.Reservations)
                .WithOptional(e => e.Loan)
                .HasForeignKey(e => e.Loans_Id);
        }
    }
}
