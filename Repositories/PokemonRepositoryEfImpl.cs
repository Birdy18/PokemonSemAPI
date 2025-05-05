using System.Data;
using Microsoft.AspNetCore.SignalR.Protocol;
using SemesterProject.Models;

namespace SemesterProject.Repositories{
    public class PokemonRepositoryEfImpl : IPokemonRepository {
        private readonly PokeDbContext dbContext;

        /// <summary>
        /// Constructor for dependency injection
        /// </summary>
        /// <param name="pokeDbContext"></param>
        public PokemonRepositoryEfImpl(PokeDbContext pokeDbContext) {
            dbContext = pokeDbContext;
        }

        //Adding the Pokemon Dex entry to the collection, and saving the changes
        public PokemonDex? AddPokemontoDex(PokemonDex pokemonDex)
        {
            dbContext.PokeDexEntries.Add(pokemonDex);
            dbContext.SaveChanges();
            return pokemonDex;
        }

        public PokemonDex? GetPokemonDexByNDN(int NDN)
        {
            return dbContext.PokeDexEntries.Find(NDN);
        }

        public PokemonDex? UpdatePokemonDex(PokemonDex pokemonDex)
        {
            dbContext.PokeDexEntries.Update(pokemonDex);
            dbContext.SaveChanges();
            return pokemonDex;
        }

        public void DeletePokemonDexByNDN(PokemonDex pokemonDexToDelete) {
            dbContext.PokeDexEntries.Remove(pokemonDexToDelete);
            dbContext.SaveChanges();
        }

        public PokemonIndividual? AddPokemontoIndividual(PokemonIndividual pokeIndividual)
        {
            dbContext.PokeIndividual.Add(pokeIndividual);
            dbContext.SaveChanges();
            return pokeIndividual;
        }

        public PokemonIndividual? GetPokemonIndividualById(int id) {
            return dbContext.PokeIndividual.Find(id);
        }
    }
}