namespace POKEMONSEMAPI.Models.Requests {
    public class PokemonCreateRequest {
        public int ID{get; set;}
        public int NationalDexNumber{get; set;}
        public string? PokemonName{get;set;}
        public int HPBaseStat{get; set;}
        public int ATKBaseStat{get; set;}
        public int DEFBaseStat{get; set;}
        public int SPATKBaseStat{get; set;}
        public int SPDEFBaseStat{get; set;}
        public int SPDBaseStat{get; set;}
    }
}