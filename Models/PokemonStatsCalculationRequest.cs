namespace POKEMONSEMAPI.Models{
    public class PokemonStatsCalculationRequest{
        public static PokemonInstance CalculatePokemonStats(PokemonDex dex, PokemonInstance instance) {
            instance.HP = (((2 * dex.HPBaseStat + instance.HPIV + (instance.HPEV/4)) * instance.PokemonLevel)/100) + instance.PokemonLevel + 10;
            instance.Attack = (((2 * dex.ATKBaseStat + instance.ATKIV + (instance.ATKEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.Defense = (((2 * dex.DEFBaseStat + instance.DEFIV + (instance.DEFEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.SpAttack = (((2 * dex.SPATKBaseStat + instance.SPATKIV + (instance.SPATKEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.SpDefense = (((2 * dex.SPDEFBaseStat + instance.SPDEFIV + (instance.SPDEFEV/4)) * instance.PokemonLevel)/100) + 5;
            instance.Speed = (((2 * dex.SPDBaseStat + instance.SPDIV + (instance.SPDEV/4)) * instance.PokemonLevel)/100) + 5;
            return instance;
        }
    }
}