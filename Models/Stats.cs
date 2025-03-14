namespace POKEMONSEMAPI.Models{
    public class HP{
        int CurrentHP{get; set;}
        int MaxHP{get; set;}
        int HPEV{get; set;}
        int HPIV{get; set;}
    }

    public class Attack{
        int CurrentATK{get; set;}
        int MaxATK{get; set;}
        int ATKEV{get; set;}
        int ATKIV{get; set;}
    }

    public class Defense{
        int CurrentDEF{get; set;}
        int MaxDEF{get; set;}
        int DEFEV{get; set;}
        int DEFIV{get; set;}
    }

    public class SpecialAttack{
        int CurrentSPATK{get; set;}
        int MaxSPATK{get; set;}
        int SPATKEV{get; set;}
        int SPATKIV{get; set;}
    }

    public class SpecialDefense{
        int CurrentSPDEF{get; set;}
        int MaxSPDEF{get; set;}
        int SPDEFEV{get; set;}
        int SPDEFIV{get; set;}
    }

    public class Speed{
        int CurrentSPD{get; set;}
        int MaxSPD{get; set;}
        int SPDEV{get; set;}
        int SPDIV{get; set;}
    }
}