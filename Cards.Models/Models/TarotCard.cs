namespace Cards.Models;

public abstract class TarotCard : ICard
{
    public abstract string Name { get; }
    public string[] Upright { get; }
    public string[] Reversed { get; }

    public TarotCard(
        string[] upright,
        string[] reversed
    )
    {
        Upright = upright;
        Reversed = reversed;
    }
}

public class MinorTarotCard : TarotCard
{
    public int Value { get; }
    public TarotSuit Suit { get; }
    public TarotZodiac[] Zodiac { get; }

    public MinorTarotCard(
        int value,
        TarotSuit suit,
        TarotZodiac[] zodiac,
        string[] upright,
        string[] reversed
    ) : base(upright, reversed)
    {
        Value = value;
        Suit = suit;
        Zodiac = zodiac;
    }

    private string ValueName => Value switch
    {
        1 => "Ace",
        11 => "Page",
        12 => "Knight",
        13 => "Queen",
        14 => "King",
        _ => Value.ToString()
    };
    public override string Name =>
        $"{ValueName} of {Suit}";
}

public class MajorTarotCard : TarotCard
{
    public override string Name { get; }
    public int Value { get; }
    public TarotAstrology Astrology { get; }

    public MajorTarotCard(
        string name,
        int value,
        TarotAstrology astrology,
        string[] upright,
        string[] reversed
    ) : base(upright, reversed)
    {
        Name = name;
        Value = value;
        Astrology = astrology;
    }
}