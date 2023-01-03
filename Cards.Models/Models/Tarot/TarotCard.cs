namespace Cards.Models;

public abstract class TarotCard : TarotBase, ICard
{
    public abstract string Name { get; }
    public string Type { get; }
    public string[] Upright { get; }
    public string[] Reversed { get; }
    public bool IsUpright { get; }

    public TarotCard(
        int id,
        string type,
        string[] upright,
        string[] reversed
    ) : base(id)
    {
        Upright = upright;
        Reversed = reversed;
        Type = type;

        IsUpright = new Random().Next() % 2 == 0;
    }

    public string Keywords => IsUpright
        ? string.Join(", ", Upright)
        : string.Join(", ", Reversed);

    public static List<TarotCard> Deck() =>
        MajorArcana
            .Cards()
            .Cast<TarotCard>()
            .Concat(
                MinorArcana
                    .Cards()
                    .Cast<TarotCard>()
            )
            .ToList();
}

public class MinorTarotCard : TarotCard
{
    public int SuitId { get; }
    public int Value { get; }

    public MinorTarotCard(
        int id,
        int value,
        TarotSuit suit,
        string[] upright,
        string[] reversed
    ) : base(id, "Minor", upright, reversed)
    {
        Value = value;
        SuitId = suit.Id;
    }

    public TarotSuit Suit => TarotSuits.Suits().Get(SuitId);

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
    public int AstrologyId { get; }
    public int ElementId { get; }
    public int Value { get; }
    public string AstrologyType { get; }

    public MajorTarotCard(
        string name,
        int value,
        TarotAstrology astrology,
        TarotElement element,
        string[] upright,
        string[] reversed
    ) : base(value, "Major", upright, reversed)
    {
        Name = name;
        Value = value;
        AstrologyId = astrology.Id;
        AstrologyType = astrology.Type;
        ElementId = element.Id;
    }

    public TarotAstrology Astrology => TarotAstrology.Get(AstrologyId, AstrologyType);
    public TarotElement Element => TarotElements.Elements().Get(ElementId);
}