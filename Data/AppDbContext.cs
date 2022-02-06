using Microsoft.EntityFrameworkCore;
using PokeAPIGQL.Models;

namespace PokeAPIGQL.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<PokemonType> PokemonTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Pokemon>()
        .HasMany(p => p.Types)
        .WithOne(t => t.Pokemon)
        .HasForeignKey(t => t.PokemonId);

      modelBuilder.Entity<PokemonType>()
        .HasOne(t => t.Pokemon)
        .WithMany(p => p.Types)
        .HasForeignKey(t => t.PokemonId);
    }
  }
}