using Cards;

List<Card> deck = Deck.Build();

Console.WriteLine("Deck.Build():");
Console.WriteLine("-------------");
foreach (Card card in deck)
    Console.WriteLine(card.ToString());
Console.WriteLine();

deck.Shuffle();
Console.WriteLine("Shuffle():");
Console.WriteLine("----------");
foreach (Card card in deck)
    Console.WriteLine(card.ToString());