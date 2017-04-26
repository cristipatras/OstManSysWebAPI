namespace OstManSysWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManSysContext : DbContext
    {
        public ManSysContext()
            : base("name=ManSysContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Apartment>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<Apartment>()
                .HasMany(e => e.Residents)
                .WithRequired(e => e.Apartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Resident>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
