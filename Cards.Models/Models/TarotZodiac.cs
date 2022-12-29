namespace Cards.Models;

public class TarotZodiac : TarotAstrology
{
    private readonly DateOnly StartDate;
    private readonly DateOnly EndDate;
    public override string Name { get; }
    public string Dates => $"{StartDate:MMM dd} - {EndDate:MMM dd}";
    public TarotElement Element { get; }
    public TarotModality Modality { get; }
    public TarotPlanet Ruler { get; set; }
    public string[] PositiveTraits { get; set; }
    public string[] NegativeTraits { get; set; }

    public TarotZodiac(
        string name,
        DateOnly startDate,
        DateOnly endDate,
        TarotElement element,
        TarotModality modality,
        TarotPlanet ruler,
        string[] positiveTraits,
        string[] negativeTraits
    )
    {
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
        Element = element;
        Modality = modality;
        Ruler = ruler;
        PositiveTraits = positiveTraits;
        NegativeTraits = negativeTraits;
    }

    public override string[] Keywords =>
        PositiveTraits
            .Concat(NegativeTraits)
            .ToArray();
}