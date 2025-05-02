using Microsoft.AspNetCore.SignalR.Protocol;
using POKEMONSEMAPI.Models;

namespace POKEMONSEMAPI.Repositories{
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

        public PokemonInstance? AddPokemontoIntance(PokemonInstance pokemonInstance)
        {
            dbContext.Pokemon.Add(pokemonInstance);
            dbContext.SaveChanges();
            return pokemonInstance;
        }

        //Adding the variant of the Pokemon to the collection, and saving the changes
        public PokemonInstance? CalculatePokemonStats(PokemonInstance pokeINT)
        {
            PokemonStatsCalculationRequest.CalculatePokemonStats(pokeINT);
            dbContext.Pokemon.Add(pokeINT);
            dbContext.SaveChanges();
            return pokeINT;
        }
    }
}