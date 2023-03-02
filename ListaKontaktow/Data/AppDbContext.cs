using Microsoft.EntityFrameworkCore;

namespace ListaKontaktow.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kontakt> Kontakty { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Podkategoria> Podkategorie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kontakt>().HasData(GetKontakty());

            modelBuilder.Entity<Kategoria>().HasData(GetKategorie());

            modelBuilder.Entity<Podkategoria>().HasData(GetPodkategorie());
        }

        private List<Kontakt> GetKontakty()
        {
            return new List<Kontakt>();
        }

        private List<Kategoria> GetKategorie()
        {
            return new List<Kategoria>();
        }

        private List<Podkategoria> GetPodkategorie()
        {
            return new List<Podkategoria>();
        }
    }
}
