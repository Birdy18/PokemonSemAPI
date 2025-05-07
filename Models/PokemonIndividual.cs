
using System.ComponentModel.DataAnnotations;

namespace SemesterProject.Models{
    /// <summary>
    /// Class where the stats are calculated for a specific...
    /// Pokemon
    /// </summary>
    public class PokemonIndividual {
        [Key]
        public int ID{get; set;}
        public string? BuildName{get; set;}
        public int PokemonLevel{get; set;}
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
        public PokemonDex? PokemonDex{get; set;}
    }
}