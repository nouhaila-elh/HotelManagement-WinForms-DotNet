using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GestionHotel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model18")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<employe> employes { get; set; }
        public virtual DbSet<hotel> hotels { get; set; }
        public virtual DbSet<prestation> prestations { get; set; }
        public virtual DbSet<reservation> reservations { get; set; }
        public virtual DbSet<categories1> categories1 { get; set; }
        public virtual DbSet<chambres1> chambres1 { get; set; }
        public virtual DbSet<clients1> clients1 { get; set; }
        public virtual DbSet<employes1> employes1 { get; set; }
        public virtual DbSet<hotelcategory> hotelcategories { get; set; }
        public virtual DbSet<hotels1> hotels1 { get; set; }
        public virtual DbSet<prestations1> prestations1 { get; set; }
        public virtual DbSet<reservations1> reservations1 { get; set; }
        public virtual DbSet<chambre> chambres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            modelBuilder.Entity<categories1>()
                .HasMany(e => e.chambres1)
                .WithOptional(e => e.categories1)
                .HasForeignKey(e => e.categorieid);

            modelBuilder.Entity<categories1>()
                .HasMany(e => e.hotelcategories)
                .WithOptional(e => e.categories1)
                .HasForeignKey(e => e.categorieid);

            modelBuilder.Entity<chambres1>()
                .HasMany(e => e.reservations1)
                .WithOptional(e => e.chambres1)
                .HasForeignKey(e => e.chambreid);

            modelBuilder.Entity<clients1>()
                .HasMany(e => e.reservations1)
                .WithOptional(e => e.clients1)
                .HasForeignKey(e => e.clientid);

            modelBuilder.Entity<hotels1>()
                .HasMany(e => e.chambres1)
                .WithOptional(e => e.hotels1)
                .HasForeignKey(e => e.hotelid);

            modelBuilder.Entity<hotels1>()
                .HasMany(e => e.hotelcategories)
                .WithRequired(e => e.hotels1)
                .HasForeignKey(e => e.hotelid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<reservations1>()
                .HasMany(e => e.prestations1)
                .WithOptional(e => e.reservations1)
                .HasForeignKey(e => e.reservationid);
        }
    }
}
