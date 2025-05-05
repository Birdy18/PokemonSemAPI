using Microsoft.EntityFrameworkCore;
using POKESEMAPIDatabase.Models;
namespace POKESEMAPIDatabase.Repositories
{
    public class PokeDbContext : DbContext
    {
        public PokeDbContext(DbContextOptions<PokeDbContext> options) : base(options) { }
        public DbSet<PokemonDex> PokeDexEntries{get; set;}
        public DbSet<PokemonIndividual> PokeIndividual{get; set;}
    }
}