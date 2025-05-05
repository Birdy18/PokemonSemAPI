using System.Data.Common;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POKEMONSEMAPI.Models;
using POKEMONSEMAPI.Models.Requests;
using POKEMONSEMAPI.Repositories;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
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
        public PokemonDex AddPokemon(PokemonDexCreateRequest request){
            PokemonDex pokemon = new PokemonDex();
            pokemon.NationalDexNumber = request.NationalDexNumber;
            pokemon.PokemonName = request.PokemonName;
            pokemon.PokemonType = request.PokemonType;
            pokemon.HPBaseStat = request.HPBaseStat;
            pokemon.ATKBaseStat = request.ATKBaseStat;
            pokemon.DEFBaseStat = request.DEFBaseStat;
            pokemon.SPATKBaseStat = request.SPATKBaseStat;
            pokemon.SPDEFBaseStat = request.SPDEFBaseStat;
            pokemon.SPDBaseStat = request.SPDBaseStat;

            return pokemonRepository.AddPokemontoDex(pokemon);
        }

        [HttpGet("{NDN}", Name = "GetPokemonDexByNDN")]
        public PokemonDex? GetPokemonDexById(int NDN) {
            //Returns the PokemonDex NationalDexNumber.  NULL if no NDN
            return pokemonRepository.GetPokemonDexByNDN(NDN);
        }

        [HttpPut("{NDN}", Name = "UpdatePokmeonDexByNDN")]
        public PokemonDex UpdatePokemonDexByNDN(int NDN, PokemonDexCreateRequest request) {
            PokemonDex? pokemonDexToUpdate = pokemonRepository.GetPokemonDexByNDN(NDN);
            if(pokemonDexToUpdate == null) {
                throw new Exception($"PokemonDex {NDN} was not found.");
            }
            pokemonDexToUpdate.PokemonName = request.PokemonName;
            pokemonDexToUpdate.PokemonType = request.PokemonType;
            pokemonDexToUpdate.HPBaseStat = request.HPBaseStat;
            pokemonDexToUpdate.ATKBaseStat = request.ATKBaseStat;
            pokemonDexToUpdate.DEFBaseStat = request.DEFBaseStat;
            pokemonDexToUpdate.SPATKBaseStat = request.SPATKBaseStat;
            pokemonDexToUpdate.SPDEFBaseStat = request.SPDEFBaseStat;
            pokemonDexToUpdate.SPDBaseStat = request.SPDBaseStat;
            
            return pokemonRepository.UpdatePokemonDex(pokemonDexToUpdate);
        }

        [HttpDelete("{NDN}", Name = "DeletePokemonDexByNDN")]
        public void DeletePokemonDexByNDN(int NDN) {
            PokemonDex? pokemonDexToDelete = pokemonRepository.GetPokemonDexByNDN(NDN);
            if(pokemonDexToDelete == null) {
                throw new Exception($"PokemonDex {NDN} is not found.");
            }
            pokemonRepository.DeletePokemonDexByNDN(pokemonDexToDelete);
        }

        [HttpPost("addIndividual", Name = "AddPokemonIndividual")]
        public PokemonIndividual AddPokemonIndividual(PokemonIndividualCreateRequest request) {
            PokemonIndividual instance = new PokemonIndividual();
            instance.BuildName = request.BuildName;
            instance.PokemonLevel = request.PokemonLevel;
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
            instance.SPDIV = request.SPDIV;

            return pokemonRepository.AddPokemontoIndividual(instance);
            
        }
    }
}