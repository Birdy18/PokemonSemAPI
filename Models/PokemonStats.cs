using System.ComponentModel.DataAnnotations;

namespace SemesterProject.Models {
    public class PokemonStats {
        [Key]
        public int CalcId{get; set;}
        public int HP{get; set;}
        public int Attack{get; set;}
        public int Defense{get; set;}
        public int SpAttack{get; set;}
        public int SpDefense{get; set;}
        public int Speed{get; set;}

        //Navigational Property

        public PokemonDex DexId{get; set;}
        public PokemonIndividual IndvId{get; set;}
    }
}