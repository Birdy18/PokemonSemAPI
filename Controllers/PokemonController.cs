using System.Data.Common;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POKEMONSEMAPI.Models;
using POKEMONSEMAPI.Models.Requests;
using POKEMONSEMAPI.Repositories;
using Microsoft.Extensions.Options;
namespace POKEMONSEMAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository pokemonRepository;
        //private readonly PokeDbContext _context;
        // Constructor to inject the DbContext
        public PokemonController(IPokemonRepository repository)
        {
            pokemonRepository = repository;
        }
        
        [HttpPost("addPokemon", Name = "AddPokemon")]
        public PokemonDex AddPokemon(PokemonCreateRequest request){
            PokemonDex pokemon = new PokemonDex();
            pokemon.NationalDexNumber = request.NationalDexNumber;
            pokemon.PokemonName = request.PokemonName;
            pokemon.HPBaseStat = request.HPBaseStat;
            pokemon.ATKBaseStat = request.ATKBaseStat;
            pokemon.DEFBaseStat = request.DEFBaseStat;
            pokemon.SPATKBaseStat = request.SPATKBaseStat;
            pokemon.SPDEFBaseStat = request.SPDEFBaseStat;
            pokemon.SPDBaseStat = request.SPDBaseStat;

            return pokemonRepository.AddPokemontoDex(pokemon);
        }

        [HttpPost("calPokeStats", Name = "CalculatePokemonStats")]
        public PokemonInstance CalculatePokemonStats(PokemonInstanceCreateRequest request) {
            //Mapping PokemonInstanceCreateRequest to the PokemonInstance
            
            PokemonInstance instance = new()
            {
                Nickname = request.Nickname,
                PokemonLevel = request.PokemonLevel,
                HPIV = request.HPIV,
                ATKIV = request.ATKIV,
                DEFIV = request.DEFIV,
                SPATKIV = request.SPATKIV,
                SPDEFIV = request.SPDEFIV,
                SPDIV = request.SPDIV,
                HPEV = request.HPEV, 
                ATKEV = request.ATKEV,
                DEFEV = request.DEFEV,
                SPATKEV = request.SPATKEV,
                SPDEFEV = request.SPDEFEV,
                SPDEV = request.SPDEV,
            };
                return pokemonRepository.CalculatePokemonStats(instance);
        }
    }
}