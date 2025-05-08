using SemesterProject.Models;
using SemesterProject.Models.Requests;

namespace SemesterProject.Repositories{
    public interface IPokemonRepository{
        /// <summary>
        /// Adds a new Pokemon to the Dex
        /// </summary>
        /// <param name="pokemonDex"></param>
        /// <returns>The Pokemon in the Dex, with stats and everything</returns>
        PokemonDex? AddPokemontoDex(PokemonDex pokemonDex);

        /// <summary>
        /// Get PokemonDex entry by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The PokemonDex entry</returns>
        PokemonDex? GetPokemonDexByNDN(int NDN);

        List<PokemonDex> GetAllPokemonDexEntries();

        PokemonDex UpdatePokemonDex(PokemonDex PokemonDexToUpdate);

        void DeletePokemonDexByNDN(PokemonDex pokemonDexToDelete);

        PokemonIndividual? AddPokemontoIndividual(PokemonIndividual pokeIndividual);

        PokemonIndividual? GetPokemonIndividualById(int id);

        List<PokemonIndividual> GetAllPokemonIndividuals();

        PokemonIndividual UpdatePokemonIndividual(PokemonIndividual PokemonIndividualToUpdate);

        void DeletePokemonIndvById(PokemonIndividual pokemonIndvToDelete);

        PokemonStats? CalculatePokemonStats(PokemonStats pokemonStats);
    }
}