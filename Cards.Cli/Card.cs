namespace Cards;
public enum Suits
{
    Spade,
    Heart,
    Club,
    Diamond
}

public class Card : ICard
{
    readonly int value;
    readonly Suits suit;

    public Card(int value, Suits suit)
    {
        this.value = value;
        this.suit = suit;
    }

    public override string ToString() => $"{Value()} of {Suit()}";

    public string Value() => value switch
    {
        1 => "Ace",
        11 => "Jack",
        12 => "Queen",
        13 => "King",
        _ => value.ToString()
    };

    public string Suit() => suit switch
    {
        Suits.Spade => "Spades",
        Suits.Heart => "Hearts",
        Suits.Club => "Clubs",
        Suits.Diamond => "Diamonds",
        _ => throw new ArgumentOutOfRangeException(nameof(suit), $"Not expected suit value: {suit}")
    };
}