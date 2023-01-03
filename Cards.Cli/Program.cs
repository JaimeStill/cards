using Cards.Models;

Console.WriteLine("Standard Cards");
Console.WriteLine("--------------");

Random rng = new();

List<StandardCard> deck = StandardCard
    .Deck()
    .Shuffle((uint)rng.Next(0, 12));

List<StandardCard> p1 = new();
List<StandardCard> p2 = new();

for (int i = 0; i < 7; i++)
{
    p1.Add(deck.Deal());
    p2.Add(deck.Deal());
}

Console.WriteLine("Player 1:");
p1.ForEach(card => Console.WriteLine(card.Name));
Console.WriteLine();

Console.WriteLine("Player 2:");
p2.ForEach(card => Console.WriteLine(card.Name));
Console.WriteLine();

Console.WriteLine($"Deck Size: {deck.Count}");
Console.WriteLine();

Console.WriteLine("Tarot Cards");
Console.WriteLine("-----------");

List<TarotCard> tarot = TarotCard.Deck.Shuffle(6);
TarotCard past = tarot.Deal();
TarotCard present = tarot.Deal();
TarotCard future = tarot.Deal();

Console.WriteLine("Past:");
PrintTarotResult(past);
Console.WriteLine();

Console.WriteLine("Present:");
PrintTarotResult(present);
Console.WriteLine();

Console.WriteLine("Future:");
PrintTarotResult(future);
Console.WriteLine();

static void PrintTarotResult<T>(T card) where T : TarotCard
{
    Console.WriteLine($"Card: {card.Name}");
    Console.WriteLine($"Orientation: {(card.IsUpright ? "Upright" : "Reversed")}");

    if (card is MajorTarotCard major)
    {
        Console.WriteLine($"Element: {major.Element.Name}");
        Console.WriteLine($"{major.AstrologyType}: {major.Astrology.Name}"); 
    }
    else if (card is MinorTarotCard minor)
    {
        Console.WriteLine($"Element: {minor.Suit.Element.Name}");
        Console.WriteLine($"Zodiacs: {string.Join(", ", minor.Suit.Element.Zodiacs.Select(x => x.Name))}");
    }

    Console.WriteLine($"Keywords: {card.Keywords}");
    Console.WriteLine($"Image: {card.Image}");
    Console.WriteLine($"Link: {card.Link}");
}