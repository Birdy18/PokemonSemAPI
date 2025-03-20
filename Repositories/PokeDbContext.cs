using Microsoft.EntityFrameworkCore;
using POKEMONSEMAPI.Models;
namespace POKEMONSEMAPI.Repositories
{
    public class PokeDbContext : DbContext
    {
        public PokeDbContext(DbContextOptions<PokeDbContext> options) : base(options) { }
        public DbSet<PokemonDex> Pokemon { get; set;}
        public DbSet<PokemonInstance> InstPokemon{get; set;}
        public DbSet<PokemonMove> pokemonMoves{get; set;}
    }
}