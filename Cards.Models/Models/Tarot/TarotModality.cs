namespace Cards.Models;

public class TarotModality : TarotBase
{
    public string Name { get; }
    public string[] Keywords { get; }

    public TarotModality(int id, string name, params string[] keywords) : base(id)
    {
        Name = name;
        Keywords = keywords;
    }

    public IEnumerable<TarotZodiac> Zodiacs => TarotZodiacs.GetByModality(this);
}