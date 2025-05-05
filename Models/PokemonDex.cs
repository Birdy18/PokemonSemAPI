using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
namespace SemesterProject.Models{
/// <summary>
/// This class focuses on the basic attributes of the Pokemon species
/// </summary>
public class PokemonDex
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NationalDexNumber{get; set;}
        public string? PokemonName{get;set;}
        public string? PokemonType{get; set;}
        public int HPBaseStat{get; set;}
        public int ATKBaseStat{get; set;}
        public int DEFBaseStat{get; set;}
        public int SPATKBaseStat{get; set;}
        public int SPDEFBaseStat{get; set;}
        public int SPDBaseStat{get; set;}

        //Navigational Instance...
        public List<PokemonIndividual> PokemonInstance{get; set;}
    }
}