using System.ComponentModel.DataAnnotations;

namespace POKEMONSEMAPI.Models.Requests{
    public class PokemonInstanceCreateRequest{

        [Required]
        public PokemonDex DexNumber{get; set;}

        [Required]
        [MinLength(5)]
        [MaxLength(12)]
        public string Nickname{get; set;}

        [Required]
        public int PokemonLevel{get; set;}

        //HP Individual Value
        public int HPIV{get; set;}

        //Attack Individual Value
        public int ATKIV{get; set;}

        //Defense Individual Value
        public int DEFIV{get; set;}

        //Special Attack Individual Value
        public int SPATKIV{get; set;}

        //Special Defense Individual Value
        public int SPDEFIV{get; set;}

        //Speed Individual Value
        public int SPDIV{get; set;}

        //HP Effort Value
        public int HPEV{get; set;}

        //Attack Effort Value
        public int ATKEV{get; set;}

        //Defense Effort Value
        public int DEFEV{get; set;}

        //Special Attack Effort Value
        public int SPATKEV{get; set;}

        //Special Defense Effort Value
        public int SPDEFEV{get; set;}

        //Speed Effort Value
        public int SPDEV{get; set;}
    }
}