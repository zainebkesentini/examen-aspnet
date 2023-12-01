using examen.Models;
using Microsoft.EntityFrameworkCore;
using static examen.Models.Entreprise;

namespace examen.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DemandeOffreEntreprise>().HasKey(am => new
            {
                am.IdDemande,
                am.IdOffre
            });

            modelBuilder.Entity<DemandeOffreEntreprise>().HasOne(m => m.OffreEmplois).WithMany(am => am.DemandesOffres).HasForeignKey(m => m.IdOffre);
            modelBuilder.Entity<OffreEmplois>().HasOne(m => m.Entreprises).WithMany(am => am.Offres).HasForeignKey(m => m.IdEntreprise);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<OffreEmplois> Offres { get; set; }
        public DbSet<DemandeOffreEntreprise> Demandes{ get; set; }
        



    }

}
