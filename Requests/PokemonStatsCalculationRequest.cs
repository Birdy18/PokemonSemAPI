using System.ComponentModel.DataAnnotations;

namespace POKEMONSEMAPI.Models{
    public class PokemonStatsCalculationRequest{
        public static PokemonIndividual CalculatePokemonStats(PokemonIndividual individual) {
            individual.HP = (((2 * individual.PokemonDex.HPBaseStat + individual.HPIV + (individual.HPEV/4)) * individual.PokemonLevel)/100) + individual.PokemonLevel + 10;
            individual.Attack = (((2 * individual.PokemonDex.ATKBaseStat + individual.ATKIV + (individual.ATKEV/4)) * individual.PokemonLevel)/100) + 5;
            individual.Defense = (((2 * individual.PokemonDex.DEFBaseStat + individual.DEFIV + (individual.DEFEV/4)) * individual.PokemonLevel)/100) + 5;
            individual.SpAttack = (((2 * individual.PokemonDex.SPATKBaseStat + individual.SPATKIV + (individual.SPATKEV/4)) * individual.PokemonLevel)/100) + 5;
            individual.SpDefense = (((2 * individual.PokemonDex.SPDEFBaseStat + individual.SPDEFIV + (individual.SPDEFEV/4)) * individual.PokemonLevel)/100) + 5;
            individual.Speed = (((2 * individual.PokemonDex.SPDBaseStat + individual.SPDIV + (individual.SPDEV/4)) * individual.PokemonLevel)/100) + 5;
            return individual;
        }
    }
}