namespace POKEMONSEMAPI.Models{
    public class PokemonMove{
        public int MoveID{get; set;}
        public string? MoveName{get; set;}
        public string? MoveType{get; set;}
        public string? MoveCategory{get; set;}
        public int MovePower{get; set;}
        public float MoveAccuracy{get; set;}
    }
}