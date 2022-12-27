namespace Cards;
public static class CardExtensions
{
    public static List<Card> Shuffle(this List<Card> cards, uint shuffles = 0)
    {
        Random rng = new();
        int n = cards.Count;

        do
        {
            for (int i = 0; i < n - 1; i++)
            {
                int r = i + rng.Next(n - i);
                (cards[i], cards[r]) = (cards[r], cards[i]);
            }

            if (shuffles > 0)
                shuffles--;
        }
        while (shuffles > 0);

        return cards;
    }

    public static Card Deal(this List<Card> cards)
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}