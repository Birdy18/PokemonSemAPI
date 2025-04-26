using System.ComponentModel.DataAnnotations;

namespace POKEMONSEMAPI.Models.Requests{
    public class PokemonInstanceCreateRequest{

        [Required]
        [MinLength(5)]
        [MaxLength(12)]
        public string Nickname{get; set;}

        [Required]
        public int PokemonLevel{get; set;}

        //HP Individual Value
        [Required]
        public int HPIV{get; set;}

        //Attack Individual Value
        [Required]
        public int ATKIV{get; set;}

        //Defense Individual Value
        [Required]
        public int DEFIV{get; set;}

        //Special Attack Individual Value
        [Required]
        public int SPATKIV{get; set;}

        //Special Defense Individual Value
        [Required]
        public int SPDEFIV{get; set;}

        //Speed Individual Value
        [Required]
        public int SPDIV{get; set;}

        //HP Effort Value
        [Required]
        public int HPEV{get; set;}

        //Attack Effort Value
        [Required]
        public int ATKEV{get; set;}

        //Defense Effort Value
        [Required]
        public int DEFEV{get; set;}

        //Special Attack Effort Value
        [Required]
        public int SPATKEV{get; set;}

        //Special Defense Effort Value
        [Required]
        public int SPDEFEV{get; set;}

        //Speed Effort Value
        [Required]
        public int SPDEV{get; set;}
    }
}