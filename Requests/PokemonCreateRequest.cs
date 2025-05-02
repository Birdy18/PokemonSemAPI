using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace POKEMONSEMAPI.Models.Requests {
    public class PokemonCreateRequest {
        [Key]
        public int ID{get; set;}
        
        [Required]
        [Key]
        public int NationalDexNumber{get; set;}
        [Required]
        [MinLength(8)]
        [MaxLength(20)]
        public string? PokemonName{get;set;}
        [Required]
        public int HPBaseStat{get; set;}
        [Required]
        public int ATKBaseStat{get; set;}
        [Required]
        public int DEFBaseStat{get; set;}
        [Required]
        public int SPATKBaseStat{get; set;}
        [Required]
        public int SPDEFBaseStat{get; set;}
        [Required]
        public int SPDBaseStat{get; set;}
    }
}