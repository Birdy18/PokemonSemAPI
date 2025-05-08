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

        public List<PokemonDex> GetAllPokemonDexEntries() {
            return dbContext.PokeDexEntries.ToList();
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

        public List<PokemonIndividual> GetAllPokemonIndividuals() {
            return dbContext.PokeIndividual.ToList();
        }

        public PokemonIndividual? UpdatePokemonIndividual(PokemonIndividual pokemonIndividual) {
            dbContext.PokeIndividual.Update(pokemonIndividual);
            dbContext.SaveChanges();
            return pokemonIndividual;
        }

        public void DeletePokemonIndvById(PokemonIndividual pokemonIndvToDelete) {
            dbContext.PokeIndividual.Remove(pokemonIndvToDelete);
            dbContext.SaveChanges();
        }

        public PokemonStats? CalculatePokemonStats(PokemonStats stats) {
            dbContext.PokemonStats.Add(stats);
            dbContext.SaveChanges();
            return stats;
        }
    }
}