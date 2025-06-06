using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SemesterProject.Models.Requests {
    public class PokemonDexCreateRequest {
        [Required]
        public int NationalDexNumber{get; set;}
        [Required]
        public string? PokemonName{get;set;}
        [Required]
        public string? PokemonType{get; set;}
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