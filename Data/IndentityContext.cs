using tw.Data.Seed;
using tw.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace tw.Data;
public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<CustomIdentityUser>(options)
{
    public DbSet<Videojuego> Videojuego { get; set; }

    public DbSet<Categoria> Categoria { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SeedCategoria());
        modelBuilder.ApplyConfiguration(new SeedVideojuego());
        modelBuilder.SeedUserIdentityData();

        base.OnModelCreating(modelBuilder);
    }
}