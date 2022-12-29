namespace Cards.Models;

public class TarotPlanet : TarotAstrology
{
    public override string Name { get; }
    public override string[] Keywords { get; }
    public TarotZodiac[] Rules { get; }
    public string Transition { get; }

    public TarotPlanet(
        string name,
        string transition,
        TarotZodiac[] rules,
        params string[] keywords
    )
    {
        Name = name;
        Transition = transition;
        Rules = rules;
        Keywords = keywords;
    }
}