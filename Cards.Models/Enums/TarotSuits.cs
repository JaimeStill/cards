namespace Cards.Models;

public static class TarotSuits
{
    public static TarotSuit Cups => new(
        "Cups",
        TarotElements.Water
    );
    
    public static TarotSuit Pentacles => new(
        "Pentacles",
        TarotElements.Earth
    );

    public static TarotSuit Swords => new(
        "Swords",
        TarotElements.Air
    );

    public static TarotSuit Wands => new(
        "Fire",
        TarotElements.Fire
    );
}