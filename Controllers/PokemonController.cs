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

        [HttpPost("addInstance", Name = "AddPokemonInstance")]
        public PokemonInstance AddPokemonINT(PokemonInstanceCreateRequest request) {
            PokemonInstance instance = new PokemonInstance();
            instance.HPEV = request.HPEV;
            instance.ATKEV = request.ATKEV;
            instance.DEFEV = request.DEFEV;
            instance.SPATKEV = request.SPATKEV;
            instance.SPDEFEV = request.SPDEFEV;
            instance.SPDEV = request.SPDEV;
            instance.HPIV = request.HPIV;
            instance.ATKIV = request.ATKIV;
            instance.DEFIV = request.DEFIV;
            instance.SPATKIV = request.SPATKIV;
            instance.SPDEFIV = request.SPDEFIV;
            instance.SPDIV = instance.SPDIV;

            return pokemonRepository.AddPokemontoInstance(instance);
            
        }

        /*
        [HttpPost("calPokeStats", Name = "CalculatePokemonStats")]
        public PokemonStats CalculatePokemonStats(int PokeIntID) {
            //Mapping PokemonInstanceCreateRequest to the PokemonInstance
            
            PokemonInstance? instance = pokemonRepository.GetPokemonInstanceByID(PokeIntID);
            PokemonInstance? dex = pokemonRepository.GetPokemonSpeciesByID(PokemonInstance.PokemonDex.NationalDexNumber);
            int HP = (((2 * instance.PokemonDex.HPBaseStat + instance.HPIV + (instance.HPEV/4)) * instance.PokemonLevel)/100) + instance.PokemonLevel + 10;
            int Attack = (((2 * instance.PokemonDex.ATKBaseStat + instance.ATKIV + (instance.ATKEV/4)) * instance.PokemonLevel)/100) + 5;
            int Defense = (((2 * instance.PokemonDex.DEFBaseStat + instance.DEFIV + (instance.DEFEV/4)) * instance.PokemonLevel)/100) + 5;
            int SpAttack = (((2 * instance.PokemonDex.SPATKBaseStat + instance.SPATKIV + (instance.SPATKEV/4)) * instance.PokemonLevel)/100) + 5;
            int SpDefense = (((2 * instance.PokemonDex.SPDEFBaseStat + instance.SPDEFIV + (instance.SPDEFEV/4)) * instance.PokemonLevel)/100) + 5;
            int Speed = (((2 * instance.PokemonDex.SPDBaseStat + instance.SPDIV + (instance.SPDEV/4)) * instance.PokemonLevel)/100) + 5;

            return new PokemonStats{
                HP = HP,
                Attack = Attack,
                Defense = Defense,
                SpAttack = SpAttack,
                SpDefense = SpDefense,
                Speed = Speed
            };
        }
        */
    }
}