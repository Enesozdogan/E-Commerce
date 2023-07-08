using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Devs_Games>().HasKey(dg => new
            {
                dg.devId,
                dg.gameId
            });
            modelBuilder.Entity<Devs_Games>().HasOne(d => d.dev).WithMany(dg=>dg.devs_games).HasForeignKey(d => d.devId);
            modelBuilder.Entity<Devs_Games>().HasOne(g => g.game).WithMany(dg => dg.devs_games).HasForeignKey(g => g.gameId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<GameModel> Games { get; set; }

        public DbSet<PlatformModel> Platforms { get; set; }
        public DbSet<DeveloperModel> Developers { get; set; }

        public DbSet<Devs_Games> Devs_Games { get; set; }

    }
}
