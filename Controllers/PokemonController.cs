using Microsoft.AspNetCore.Mvc;
using POKEMONSEMAPI.Models;
using POKEMONSEMAPI.Models.Requests;
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
        
        [HttpPost("", Name = "AddPokemon")]
        public PokemonDex AddPokemon(PokemonCreateRequest request){
            PokemonDex pokemon = new PokemonDex();
            pokemon.ID = request.ID;
            pokemon.NationalDexNumber = request.NationalDexNumber;
            pokemon.PokemonName = request.PokemonName;
            pokemon.HPBaseStat = request.HPBaseStat;
            pokemon.ATKBaseStat = request.ATKBaseStat;
            pokemon.DEFBaseStat = request.DEFBaseStat;
            pokemon.SPATKBaseStat = request.SPATKBaseStat;
            pokemon.SPDEFBaseStat = request.SPDEFBaseStat;
            pokemon.SPDBaseStat = request.SPDBaseStat;

            _context.Pokemon.Add(pokemon);

            _context.SaveChanges();

            return pokemon;
        }
    }
}