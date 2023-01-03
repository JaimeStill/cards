namespace Cards.Models;

public static class Pentacles
{
    public static List<MinorTarotCard> Cards() => new()
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Page, Knight, Queen, King
    };

    public static MinorTarotCard Ace => new(
        22,
        1,
        TarotSuits.Pentacles,
        new string[]{
            "Opportunity", "Prosperity", "New Venture"
        },
        new string[]{
            "Lost Opportunity", "Missed Chance", "Bad Investment"
        }
    );

    public static MinorTarotCard Two => new(
        23,
        2,
        TarotSuits.Pentacles,
        new string[]{
            "Balancing Decisions", "Priorties", "Adapting to Change"
        },
        new string[]{
            "Loss of Balance", "Disorganized", "Overwhelmed"
        }
    );

    public static MinorTarotCard Three => new(
        24,
        3,
        TarotSuits.Pentacles,
        new string[]{
            "Teamwork", "Collaboration", "Building"
        },
        new string[]{
            "Lack of Teamwork", "Disorganized", "Group Conflict"
        }
    );

    public static MinorTarotCard Four => new(
        25,
        4,
        TarotSuits.Pentacles,
        new string[]{
            "Conservation", "Security", "Frugality"
        },
        new string[]{
            "Greediness", "Stinginess", "Possessiveness"
        }
    );

    public static MinorTarotCard Five => new(
        26,
        5,
        TarotSuits.Pentacles,
        new string[]{
            "Need", "Poverty", "Insecurity"
        },
        new string[]{
            "Recovery", "Charity", "Improvement"
        }
    );

    public static MinorTarotCard Six => new(
        27,
        6,
        TarotSuits.Pentacles,
        new string[]{
            "Charity", "Generosity", "Sharing"
        },
        new string[]{
            "Strings Attached", "Stinginess", "Power and Domination"
        }
    );

    public static MinorTarotCard Seven => new(
        28,
        7,
        TarotSuits.Pentacles,
        new string[]{
            "Hard Work", "Perseverance", "Diligence"
        },
        new string[]{
            "Work without Results", "Distractions", "Lack of Rewards"
        }
    );

    public static MinorTarotCard Eight => new(
        29,
        8,
        TarotSuits.Pentacles,
        new string[]{
            "Diligence", "Passion", "High Standards"
        },
        new string[]{
            "No Passion", "Uninspired", "No Motivation"
        }
    );

    public static MinorTarotCard Nine => new(
        30,
        9,
        TarotSuits.Pentacles,
        new string[]{
            "Fruits of Labor", "Spending", "Rewards"
        },
        new string[]{
            "Living Beyond Means", "Obsession With Work", "False Success"
        }
    );

    public static MinorTarotCard Ten => new(
        31,
        10,
        TarotSuits.Pentacles,
        new string[]{
            "Legacy", "Inheritance", "Culmination"
        },
        new string[]{
            "Fleeting Success", "Lack of Stability", "Lack of Resources"
        }
    );

    public static MinorTarotCard Page => new(
        32,
        11,
        TarotSuits.Pentacles,
        new string[]{
            "Ambition", "Desire", "Diligence"
        },
        new string[]{
            "Lack of Commitment", "Greediness", "Laziness"
        }
    );

    public static MinorTarotCard Knight => new(
        33,
        12,
        TarotSuits.Pentacles,
        new string[]{
            "Efficiency", "Hard Work", "Responsibility"
        },
        new string[]{
            "Laziness", "Obsessed with Work", "Work without Reward"
        }
    );

    public static MinorTarotCard Queen => new(
        34,
        13,
        TarotSuits.Pentacles,
        new string[]{
            "Practicality", "Creature Comforts", "Financial Security"
        },
        new string[]{
            "Self-Centeredness", "Jealousy", "Smothering"
        }
    );

    public static MinorTarotCard King => new(
        35,
        14,
        TarotSuits.Pentacles,
        new string[]{
            "Abundance", "Propserity", "Security"
        },
        new string[]{
            "Greed", "Indulgence", "Sensuality"
        }
    );
}