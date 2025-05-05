using Microsoft.EntityFrameworkCore;
using SemesterProject.Models;
namespace SemesterProject.Repositories
{
    public class PokeDbContext : DbContext
    {
        public PokeDbContext(DbContextOptions<PokeDbContext> options) : base(options) { }
        public DbSet<PokemonDex> PokeDexEntries{get; set;}
        public DbSet<PokemonIndividual> PokeIndividual{get; set;}
    }
}