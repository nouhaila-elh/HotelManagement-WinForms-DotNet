using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GestionHotel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<chambre> chambres { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<employe> employes { get; set; }
        public virtual DbSet<hotelcategory> hotelcategories { get; set; }
        public virtual DbSet<hotel> hotels { get; set; }
        public virtual DbSet<prestation> prestations { get; set; }
        public virtual DbSet<reservationarchive> reservationarchives { get; set; }
        public virtual DbSet<reservation> reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            modelBuilder.Entity<category>()
                .HasMany(e => e.chambres)
                .WithOptional(e => e.category)
                .HasForeignKey(e => e.categorieid);

            modelBuilder.Entity<category>()
                .HasMany(e => e.hotelcategories)
                .WithOptional(e => e.category)
                .HasForeignKey(e => e.categorieid);

            modelBuilder.Entity<hotel>()
                .HasMany(e => e.hotelcategories)
                .WithRequired(e => e.hotel)
                .WillCascadeOnDelete(false);
        }
    }
}
