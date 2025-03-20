namespace POKEMONSEMAPI.Models{
    /// <summary>
    /// Class where the stats are calculated for a specific...
    /// Pokemon
    /// </summary>
    public class PokemonInstance{
        public int ID{get; set;}
        public string? Nickname{get; set;}
        public int PokemonLevel{get; set;} = 1;
        public int HP{get; set;}
        public int Attack{get; set;}
        public int Defense{get; set;}
        public int SpAttack{get; set;}
        public int SpDefense{get; set;}
        public int Speed{get; set;}
        public int IndividualValue{get; set;}
        public int EffortValue{get; set;}
    }
}