namespace POKEMONSEMAPI.Models{
    public class PokeDexEntry{
        public int ID{get; set;}
        public int NationalDexNumber{get; set;}
        public string? PokemonName{get; set;}
        public string? PokemonType{get; set;}
        public float PokeHeightInMeters{get; set;}
        public float PokeWeightInLbs{get; set;}
        public string? PokemonDescription{get; set;}

        //Foreign key: Links PokeDexEntry to Pokemon by storing the Pokemon's ID (primary key)
        public int PokemonID{get; set;}

        //Navigation Property
        //Allows to directly relate to Pokemon object in code...
        public Pokemon Pokemon{get; set;}
    }   
}