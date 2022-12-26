namespace Cards;
public static class Deck
{
    public static List<Card> Build()
    {
        List<Card> deck = new();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 1; j < 14; j++)
            {
                deck.Add(new Card(j, (Suits)i));
            }
        }

        return deck;
    }

    public static void Shuffle(this List<Card> cards)
    {
        Random rng = new();
        int n = cards.Count;

        for (int i = 0; i < n - 1; i++)
        {
            int r = i + rng.Next(n - i);
            (cards[i], cards[r]) = (cards[r], cards[i]);
        }
    }
}