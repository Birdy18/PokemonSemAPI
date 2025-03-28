namespace POKEMONSEMAPI.Models{
    /// <summary>
    /// Class where the stats are calculated for a specific...
    /// Pokemon
    /// </summary>
    public class PokemonInstance{
        public int ID{get; set;}
        public string Nickname{get; set;}
        public int PokemonLevel{get; set;} = 1;
        public int CurrentHP{get; set;}
        public int HP{get; set;}
        public int Attack{get; set;}
        public int Defense{get; set;}
        public int SpAttack{get; set;}
        public int SpDefense{get; set;}
        public int Speed{get; set;}
        public int HPIV{get; set;}
        public int ATKIV{get; set;}
        public int DEFIV{get; set;}
        public int SPATKIV{get; set;}
        public int SPDEFIV{get; set;}
        public int SPDIV{get; set;}
        public int HPEV{get; set;}
        public int ATKEV{get; set;}
        public int DEFEV{get; set;}
        public int SPATKEV{get; set;}
        public int SPDEFEV{get; set;}
        public int SPDEV{get; set;}

        //Navigational Property
        public List<PokemonDex> PokeSpecies {get; set;}
    }
}