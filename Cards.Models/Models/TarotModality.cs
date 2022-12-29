namespace Cards.Models;

public class TarotModality
{
    public string Name { get; }
    public string[] Keywords { get; }

    public TarotModality(string name, params string[] keywords)
    {
        Name = name;
        Keywords = keywords;
    }
}