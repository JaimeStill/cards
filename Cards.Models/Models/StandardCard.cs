namespace Cards.Models;

public class StandardCard : ICard
{
    readonly StandardSuit? suit;

    public StandardCard(int value, StandardSuit? suit = null)
    {
        Value = value;
        this.suit = suit;
    }

    private string ValueName => Value switch
    {
        1 => "Ace",
        11 => "Jack",
        12 => "Queen",
        13 => "King",
        14 => "Small Joker",
        15 => "Big Joker",
        _ => Value.ToString()
    };

    public int Value { get; }

    public string Name =>
        string.IsNullOrWhiteSpace(Suit)
            ? ValueName
            : $"{ValueName} of {Suit}";

    public string Suit => suit.ToString() ?? string.Empty;

    public static List<StandardCard> Deck(bool jokers = false)
    {
        List<StandardCard> deck = new();

        for (int i = 0; i < 4; i++)
            for (int j = 1; j < 14; j++)
                deck.Add(new StandardCard(j, (StandardSuit)i));

        if (jokers)
            deck.AddRange(new List<StandardCard>{
                new(14),
                new(15)
            });

        return deck;
    }
}