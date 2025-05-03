using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace POKEMONSEMAPI.Models{
    public class PokemonStats{
        [Key]
        public int ID{get; set;}
        public int HP{get; set;}
        public int Attack{get; set;}
        public int Defense{get; set;}
        public int SpAttack{get; set;}
        public int SpDefense{get;  set;}
        public int Speed{get; set;}

        //Navigational Path
        public PokemonDex dexID{get; set;}
        public PokemonIndividual intID{get; set;}
    }
}