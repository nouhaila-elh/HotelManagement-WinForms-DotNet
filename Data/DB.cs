using System.Data.Entity;

namespace GestionHotel.Data
{
    public class DB : DbContext
    {
        public DB() :base("name=myCnx"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            //modelBuilder.Entity<employe>().ToTable("employes");
        }

        public DbSet<employe> employes { get; set; }
        public DbSet<hotel> hotels { get; set; }
        public DbSet<chambre> chambres { get; set; }

    }
}