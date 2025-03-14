namespace POKEMONSEMAPI.Models.Requests {
    public class PokemonCreateRequest {
        public int NationalDexNumber{get; set;}
        public string? PokemonName{get;set;}
        public List<HP> health{get; set;}
        public List<Attack> attack{get; set;}
        public List<Defense> defense{get; set;}
        public List<SpecialAttack> specialAttack{get; set;}
        public List<SpecialDefense> specialDefense{get; set;}
        public List<Speed> speed {get; set;}
        public List<PokemonMove> moves{get; set;} = [];
    }
}