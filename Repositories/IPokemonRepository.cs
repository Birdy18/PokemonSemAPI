using POKEMONSEMAPI.Models;

namespace POKEMONSEMAPI.Repositories{
    public interface IPokemonRepository{
        /// <summary>
        /// Adds a new Pokemon to the Dex
        /// </summary>
        /// <param name="pokemonDex"></param>
        /// <returns>The Pokemon in the Dex, with stats and everything</returns>
        PokemonDex AddPokemontoDex(PokemonDex pokemonDex);

        /// <summary>
        /// Calculate the stats of the Pokemon
        /// </summary>
        /// <param name="pokemonINT"></param>
        /// <returns>The stats of the Pokemon</returns>
        PokemonInstance CalculateStats(PokemonDex pokemonDex, PokemonInstance pokemonINT);

        PokemonDex? SearchPokemonByNDN(PokemonDex NDN);
    }
}