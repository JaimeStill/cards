namespace Cards.Models;

public class TarotElement
{
    public string Name { get; set; }
    public TarotPolarity Polarity { get; }
    public string[] Keywords { get; }

    public TarotElement(
        string name,
        TarotPolarity polarity,
        params string[] keywords
    )
    {
        Name = name;
        Polarity = polarity;
        Keywords = keywords;
    }
}