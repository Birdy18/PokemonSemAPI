using POKEMONSEMAPI.Models;
using POKEMONSEMAPI.Models.Requests;

namespace POKEMONSEMAPI.Repositories{
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

        PokemonDex UpdatePokemonDex(PokemonDex PokemonDexToUpdate);

        void DeletePokemonDexByNDN(PokemonDex pokemonDexToDelete);

        PokemonIndividual? AddPokemontoIndividual(PokemonIndividual pokeIndividual);
    }
}