using System.ComponentModel.DataAnnotations;

namespace POKEMONSEMAPI.Models.Requests{
    public class PokemonIndividualCreateRequest{
        [Required]
        [MinLength(10)]
        [MaxLength(40)]
        public string? BuildName{get; set;}

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public int PokemonLevel{get; set;}

        //HP Individual Value
        [MinLength(0)]
        [MaxLength(31)]
        public int HPIV{get; set;}

        //Attack Individual Value
        [MinLength(0)]
        [MaxLength(31)]
        public int ATKIV{get; set;}

        //Defense Individual Value
        [MinLength(0)]
        [MaxLength(31)]
        public int DEFIV{get; set;}

        //Special Attack Individual Value
        [MinLength(0)]
        [MaxLength(31)]
        public int SPATKIV{get; set;}

        //Special Defense Individual Value
        [MinLength(0)]
        [MaxLength(31)]
        public int SPDEFIV{get; set;}

        //Speed Individual Value
        [MinLength(0)]
        [MaxLength(31)]
        public int SPDIV{get; set;}

        //HP Effort Value
        [MinLength(0)]
        [MaxLength(255)]
        public int HPEV{get; set;}

        //Attack Effort Value
        [MinLength(0)]
        [MaxLength(255)]
        public int ATKEV{get; set;}

        //Defense Effort Value
        [MinLength(0)]
        [MaxLength(255)]
        public int DEFEV{get; set;}

        //Special Attack Effort Value
        [MinLength(0)]
        [MaxLength(255)]
        public int SPATKEV{get; set;}

        //Special Defense Effort Value
        [MinLength(0)]
        [MaxLength(255)]
        public int SPDEFEV{get; set;}

        //Speed Effort Value
        [MinLength(0)]
        [MaxLength(255)]
        public int SPDEV{get; set;}
    }
}