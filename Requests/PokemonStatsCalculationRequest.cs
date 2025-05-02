using System.ComponentModel.DataAnnotations;

namespace POKEMONSEMAPI.Models{
    public class PokemonStatsCalculationRequest{
        [Key]
        public int ID{get; set;}
        
        public static PokemonInstance CalculatePokemonStats(PokemonInstance instance) {
            instance.HP = (((2 * instance.PokemonDex.HPBaseStat + instance.HPIV + (instance.HPEV/4)) * instance.PokemonLevel)/100) + instance.PokemonLevel + 10;
            instance.Attack = (((2 * instance.PokemonDex.ATKBaseStat + instance.ATKIV + (instance.ATKEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.Defense = (((2 * instance.PokemonDex.DEFBaseStat + instance.DEFIV + (instance.DEFEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.SpAttack = (((2 * instance.PokemonDex.SPATKBaseStat + instance.SPATKIV + (instance.SPATKEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.SpDefense = (((2 * instance.PokemonDex.SPDEFBaseStat + instance.SPDEFIV + (instance.SPDEFEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.Speed = (((2 * instance.PokemonDex.SPDBaseStat + instance.SPDIV + (instance.SPDEV/4)) * instance.PokemonLevel)/100) + 5;
            return instance;
        }
    }
}