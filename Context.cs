using Microsoft.EntityFrameworkCore;
using TestEfCodeFirst.Model;

namespace TestEfCodeFirst
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        }
        public DbSet<Kisi> Kisi { get; set; }
        public DbSet<Takim> Takim { get; set; }
        public DbSet<Grup> Grup { get; set; }
        public DbSet<GrupKisiVeri> GrupKisiVeri { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
