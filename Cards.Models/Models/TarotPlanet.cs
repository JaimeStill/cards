namespace Cards.Models;

public class TarotPlanet : TarotAstrology
{
    public override string Name { get; }
    public override string[] Keywords { get; }
    public string Transition { get; }

    public TarotPlanet(
        string name,
        string transition,
        params string[] keywords
    )
    {
        Name = name;
        Transition = transition;
        Keywords = keywords;
    }
}