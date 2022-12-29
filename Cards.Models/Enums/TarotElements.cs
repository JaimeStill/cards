namespace Cards.Models;

public static class TarotElements
{
    public static TarotElement Air => new(
        "Air",
        TarotPolarity.Active,
        "Logic", "Ideas", "Intellect", "Communication",
        "Conflict", "Awareness", "Perception"
    );

    public static TarotElement Earth => new(
        "Earth",
        TarotPolarity.Passive,
        "Physical", "Nature", "Health", "Stability", "Reliability",
        "Finances", "Practicality"
    );

    public static TarotElement Fire => new(
        "Fire",
        TarotPolarity.Active,
        "Energy", "Passion", "Action", "Inspiration", "Drive",
        "Willpower", "Ambition"
    );

    public static TarotElement Water => new(
        "Water",
        TarotPolarity.Passive,
        "Emotions", "Feelings", "Relationships", "Intuition",
        "Love", "Serenity", "Spirituality"
    );
}