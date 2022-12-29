namespace Cards.Models;

public static class TarotModalities
{
    public static TarotModality Cardinal => new(
        "Cardinal",
        "Action", "Dynamic", "Initiative", "Great Force"
    );

    public static TarotModality Fixed => new(
        "Fixed",
        "Resistance to Change", "Great Willpower", "Inflexible"
    );

    public static TarotModality Mutable => new(
        "Mutable",
        "Adaptability", "Flexibility", "Resourcefulness"
    );
}