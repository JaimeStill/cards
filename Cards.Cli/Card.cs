namespace Cards;
public enum SuitValue
{
    Spade,
    Heart,
    Club,
    Diamond
}

public class Card
{
    readonly int value;
    readonly SuitValue? suit;

    public Card(int value, SuitValue? suit = null)
    {
        this.value = value;
        this.suit = suit;
    }

    public string Value => value switch
    {
        1 => "Ace",
        11 => "Jack",
        12 => "Queen",
        13 => "King",
        14 => "Small Joker",
        15 => "Big Joker",
        _ => value.ToString()
    };

    public string Suit => suit switch
    {
        SuitValue.Spade => "Spades",
        SuitValue.Heart => "Hearts",
        SuitValue.Club => "Clubs",
        SuitValue.Diamond => "Diamonds",
        _ => string.Empty
    };

    public override string ToString() => 
        string.IsNullOrWhiteSpace(Suit)
            ? Value
            : $"{Value} of {Suit}";

    public static List<Card> Deck(bool jokers = false)
    {
        List<Card> deck = new();

        for (int i = 0; i < 4; i++)
            for (int j = 1; j < 14; j++)
                deck.Add(new Card(j, (SuitValue)i));

        if (jokers)
            deck.AddRange(new List<Card>{
                new(14),
                new(15)
            });

        return deck;
    }
}