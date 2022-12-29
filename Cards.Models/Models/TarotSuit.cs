namespace Cards.Models;

public class TarotSuit
{
    public string Name { get; }
    public TarotElement Element { get; }

    public TarotSuit(
        string name,
        TarotElement element
    )
    {
        Name = name;
        Element = element;
    }
}