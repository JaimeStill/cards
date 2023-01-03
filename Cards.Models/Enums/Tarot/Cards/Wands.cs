namespace Cards.Models;

public static class Wands
{
    public static List<MinorTarotCard> Cards() => new()
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Page, Knight, Queen, King
    };

    public static MinorTarotCard Ace => new(
        22,
        1,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Two => new(
        23,
        2,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Three => new(
        24,
        3,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Four => new(
        25,
        4,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Five => new(
        26,
        5,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Six => new(
        27,
        6,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Seven => new(
        28,
        7,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Eight => new(
        29,
        8,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Nine => new(
        30,
        9,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Ten => new(
        31,
        10,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Page => new(
        32,
        11,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Knight => new(
        33,
        12,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard Queen => new(
        34,
        13,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );

    public static MinorTarotCard King => new(
        35,
        14,
        TarotSuits.Wands,
        new string[]{
        },
        new string[]{
        }
    );
}