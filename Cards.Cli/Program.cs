using Cards;

Random rng = new();

List<Card> deck = Card
    .Deck()
    .Shuffle((uint)rng.Next(0, 12));

List<Card> p1 = new();
List<Card> p2 = new();

for (int i = 0; i < 7; i++) {
    p1.Add(deck.Deal());
    p2.Add(deck.Deal());
}

Console.WriteLine("Player 1:");
p1.ForEach(card => Console.WriteLine(card.ToString()));
Console.WriteLine();

Console.WriteLine("Player 2:");
p2.ForEach(card => Console.WriteLine(card.ToString()));
Console.WriteLine();

Console.WriteLine($"Deck Size: {deck.Count}");