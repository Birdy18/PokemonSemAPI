using System.Data.Common;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SemesterProject.Models;
using SemesterProject.Models.Requests;
using SemesterProject.Repositories;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
namespace SemesterProject.Controllers
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

        [HttpGet("/pokemon-individual/{id}", Name = "GetPokemonIndividualById")]
        public PokemonIndividual? GetPokemonIndividualById(int id) {
            return pokemonRepository.GetPokemonIndividualById(id);
        }

        [HttpPut("/pokemon-individual/{id}", Name = "PokemonIndividualToUpdate")]
        public PokemonIndividual? UpdatePokemonIndividual(int id, PokemonIndividualCreateRequest request) {
            PokemonIndividual? pokemonIndvToUpdate = pokemonRepository.GetPokemonIndividualById(id);
            if(pokemonIndvToUpdate == null) {
                throw new Exception($"PokemonIndividual {id} was not found.");
            }
            pokemonIndvToUpdate.BuildName = request.BuildName;
            pokemonIndvToUpdate.PokemonLevel = request.PokemonLevel;
            pokemonIndvToUpdate.HPIV = request.HPIV;
            pokemonIndvToUpdate.ATKIV = request.ATKIV;
            pokemonIndvToUpdate.DEFIV = request.DEFIV;
            pokemonIndvToUpdate.SPATKIV = request.SPATKIV;
            pokemonIndvToUpdate.SPDEFIV = request.SPDEFIV;
            pokemonIndvToUpdate.SPDIV = request.SPDIV;
            pokemonIndvToUpdate.HPEV = request.HPEV;
            pokemonIndvToUpdate.ATKEV = request.ATKEV;
            pokemonIndvToUpdate.DEFEV = request.DEFEV;
            pokemonIndvToUpdate.SPATKEV = request.SPATKEV;
            pokemonIndvToUpdate.SPDEFEV = request.SPDEFEV;
            pokemonIndvToUpdate.SPDEV = request.SPDEV;

            return pokemonRepository.UpdatePokemonIndividual(pokemonIndvToUpdate);
        }

        [HttpDelete("/pokemon-individual/{id}", Name = "DeletePokemonIndvById")]
        public void DeletePokemonIndvById(int id) {
            PokemonIndividual? pokeIndvToDelete = pokemonRepository.GetPokemonIndividualById(id);
            if(pokeIndvToDelete == null) {
                throw new Exception($"PokemonIndividual {id} was not found.");
            }
            pokemonRepository.DeletePokemonIndvById(pokeIndvToDelete);
        }

        [HttpPut("/pokemon-individual/stats", Name = "CalculatePokemonStats")]
        public PokemonStats? CalculatePokemonStats(int NDN, int id) {
            PokemonDex pokemonDex = pokemonRepository.GetPokemonDexByNDN(NDN);
            if(pokemonDex == null) {
                throw new Exception($"PokemonDex {NDN} was not found.");
            }
            PokemonIndividual pokemonIndividual = pokemonRepository.GetPokemonIndividualById(id);
            if(pokemonIndividual == null) {
                throw new Exception($"PokemonIndividual {id} was not found.");
            }

            PokemonStats stats = new PokemonStats();

            stats.HP = (((2 * pokemonDex.HPBaseStat + pokemonIndividual.HPIV + (pokemonIndividual.HPEV/4)) * pokemonIndividual.PokemonLevel)/100) + pokemonIndividual.PokemonLevel + 10;
            stats.Attack = (((2 * pokemonDex.ATKBaseStat + pokemonIndividual.ATKIV + (pokemonIndividual.ATKEV/4)) * pokemonIndividual.PokemonLevel)/100) + 5;
            stats.Defense = (((2 * pokemonDex.DEFBaseStat + pokemonIndividual.DEFIV + (pokemonIndividual.DEFEV/4)) * pokemonIndividual.PokemonLevel)/100) + 5;
            stats.SpAttack = (((2 * pokemonDex.SPATKBaseStat + pokemonIndividual.SPATKIV + (pokemonIndividual.SPATKEV/4)) * pokemonIndividual.PokemonLevel)/100) + 5;
            stats.SpDefense = (((2 * pokemonDex.SPDEFBaseStat + pokemonIndividual.SPDEFIV + (pokemonIndividual.SPDEFEV/4)) * pokemonIndividual.PokemonLevel)/100) + 5;
            stats.Speed = (((2 * pokemonDex.SPDBaseStat + pokemonIndividual.SPDIV + (pokemonIndividual.SPDEV/4)) * pokemonIndividual.PokemonLevel)/100) + 5;

            return stats;
         }
    }
}