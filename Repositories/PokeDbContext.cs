using Microsoft.EntityFrameworkCore;
using POKEMONSEMAPI.Models;
namespace POKEMONSEMAPI.Repositories
{
    public class PokeDbContext : DbContext
    {
        public PokeDbContext(DbContextOptions<PokeDbContext> options) : base(options) { }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}