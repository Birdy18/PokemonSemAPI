using Microsoft.AspNetCore.Mvc;
using POKEMONSEMAPI.Repositories;
namespace POKEMONSEMAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokeDbContext _context;
        // Constructor to inject the DbContext
        public PokemonController(PokeDbContext context)
        {
            _context = context;
        }
        // CRUD endpoints will be added here
    }
}