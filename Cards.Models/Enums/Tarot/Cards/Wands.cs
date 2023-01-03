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
            "Creation", "Willpower", "Inspiration", "Desire"
        },
        new string[]{
            "Lack of Energy", "Lack of Passion", "Boredom"
        }
    );

    public static MinorTarotCard Two => new(
        23,
        2,
        TarotSuits.Wands,
        new string[]{
            "Planning", "Making Decisions", "Leaving Home"
        },
        new string[]{
            "Fear of Change", "Playing it Safe", "Bad Planning"
        }
    );

    public static MinorTarotCard Three => new(
        24,
        3,
        TarotSuits.Wands,
        new string[]{
            "Looking Ahead", "Expansion", "Rapid Growth"
        },
        new string[]{
            "Obstacles", "Delays", "Frustration"
        }
    );

    public static MinorTarotCard Four => new(
        25,
        4,
        TarotSuits.Wands,
        new string[]{
            "Community", "Home", "Celebration"
        },
        new string[]{
            "Lack of Support", "Transience", "Home Conflicts"
        }
    );

    public static MinorTarotCard Five => new(
        26,
        5,
        TarotSuits.Wands,
        new string[]{
            "Competition", "Conflict", "Rivalry"
        },
        new string[]{
            "Avoiding Conflict", "Respect Differences"
        }
    );

    public static MinorTarotCard Six => new(
        27,
        6,
        TarotSuits.Wands,
        new string[]{
            "Victory", "Success", "Public Reward"
        },
        new string[]{
            "Excess Pride", "Lack of Recognition", "Punishment"
        }
    );

    public static MinorTarotCard Seven => new(
        28,
        7,
        TarotSuits.Wands,
        new string[]{
            "Perseverance", "Mount Defense", "Maintaining Control"
        },
        new string[]{
            "Giving Up", "No Confidence", "Overwhelmed"
        }
    );

    public static MinorTarotCard Eight => new(
        29,
        8,
        TarotSuits.Wands,
        new string[]{
            "Rapid Action", "Movement", "Quick Decisions"
        },
        new string[]{
            "Panic", "Waiting", "Slowing Down"
        }
    );

    public static MinorTarotCard Nine => new(
        30,
        9,
        TarotSuits.Wands,
        new string[]{
            "Resilience", "Grit", "Last Stand"
        },
        new string[]{
            "Exhaustion", "Fatigue", "Unsure Motivations"
        }
    );

    public static MinorTarotCard Ten => new(
        31,
        10,
        TarotSuits.Wands,
        new string[]{
            "Accomplishment", "Responsibility", "Burden"
        },
        new string[]{
            "Can't Delegate", "Overstressed", "Burnt Out"
        }
    );

    public static MinorTarotCard Page => new(
        32,
        11,
        TarotSuits.Wands,
        new string[]{
            "Exploration", "Excitement", "Freedom"
        },
        new string[]{
            "Lack of Direction", "Procrastination", "Creating Conflict"
        }
    );

    public static MinorTarotCard Knight => new(
        33,
        12,
        TarotSuits.Wands,
        new string[]{
            "Action", "Adventure", "Fearlessness"
        },
        new string[]{
            "Anger", "Impulsivity", "Recklessness"
        }
    );

    public static MinorTarotCard Queen => new(
        34,
        13,
        TarotSuits.Wands,
        new string[]{
            "Courage", "Determination", "Joy"
        },
        new string[]{
            "Selfishness", "Jealousy", "Insecurity"
        }
    );

    public static MinorTarotCard King => new(
        35,
        14,
        TarotSuits.Wands,
        new string[]{
            "Big Picture", "Leader", "Overcoming Challenges"
        },
        new string[]{
            "Impulsive", "Overbearing", "Impossible Expectations"
        }
    );
}