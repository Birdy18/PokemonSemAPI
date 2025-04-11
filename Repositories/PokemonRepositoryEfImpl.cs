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
        public PokemonDex AddPokemontoDex(PokemonDex pokemonDex)
        {
            dbContext.Pokemon.Add(pokemonDex);
            dbContext.SaveChanges();
            return pokemonDex;
        }

        //Adding the variant of the Pokemon to the collection, and saving the changes
        public PokemonInstance CalculateStats(PokemonInstance pokeINT)
        {
            dbContext.InstPokemon.Add(pokeINT);
            dbContext.SaveChanges();
            return pokeINT;
        }

        public PokemonDex? SearchPokemonByNDN(PokemonDex NDN)
        {
            return dbContext.Pokemon.Find(NDN);
        }
    }
}