namespace Cards.Models;

public static class Swords
{
    public static List<MinorTarotCard> Cards() => new()
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Page, Knight, Queen, King
    };

    public static MinorTarotCard Ace => new(
        22,
        1,
        TarotSuits.Swords,
        new string[]{
            "Breakthrough", "Clarity", "Sharp Mind"
        },
        new string[]{
            "Confusion", "Brutality", "Chaos"
        }
    );

    public static MinorTarotCard Two => new(
        23,
        2,
        TarotSuits.Swords,
        new string[]{
            "Difficult Choices", "Indecision", "Stalemate"

        },
        new string[]{
            "Lesser of Two Evils", "No Right Choice", "Confusion"
        }
    );

    public static MinorTarotCard Three => new(
        24,
        3,
        TarotSuits.Swords,
        new string[]{
            "Heartbreak", "Suffering", "Grief"
        },
        new string[]{
            "Recovery", "Forgiveness", "Moving On"
        }
    );

    public static MinorTarotCard Four => new(
        25,
        4,
        TarotSuits.Swords,
        new string[]{
            "Rest", "Restoration", "Contemplation"
        },
        new string[]{
            "Restlessness", "Burnout", "Stress"
        }
    );

    public static MinorTarotCard Five => new(
        26,
        5,
        TarotSuits.Swords,
        new string[]{
            "Unbridled Ambition", "Win at All Costs", "Sneakiness"
        },
        new string[]{
            "Resentment", "Desire to Reconcile", "Desire to Forgive"
        }
    );

    public static MinorTarotCard Six => new(
        27,
        6,
        TarotSuits.Swords,
        new string[]{
            "Transition", "Leaving Behind", "Moving On"
        },
        new string[]{
            "Emotional Baggage", "Unresolved Issues", "Resisting Transition"
        }
    );

    public static MinorTarotCard Seven => new(
        28,
        7,
        TarotSuits.Swords,
        new string[]{
            "Deception", "Trickery", "Tactics & Strategy"
        },
        new string[]{
            "Coming Clean", "Rethinking Approach", "Deception"
        }
    );

    public static MinorTarotCard Eight => new(
        29,
        8,
        TarotSuits.Swords,
        new string[]{
            "Imprisonment", "Entrapment", "Self-Victimization"
        },
        new string[]{
            "Self-Acceptance", "New Perspective", "Freedom"
        }
    );

    public static MinorTarotCard Nine => new(
        30,
        9,
        TarotSuits.Swords,
        new string[]{
            "Anxiety", "Hopelessness", "Trauma"
        },
        new string[]{
            "Hope", "Reaching Out", "Despair"
        }
    );

    public static MinorTarotCard Ten => new(
        31,
        10,
        TarotSuits.Swords,
        new string[]{
            "Failure", "Collapse", "Defeat"
        },
        new string[]{
            "Can't Get Worse", "Only Upwards", "Inevitable End"
        }
    );

    public static MinorTarotCard Page => new(
        32,
        11,
        TarotSuits.Swords,
        new string[]{
            "Curiosity", "Restlessness", "Mental Energy"
        },
        new string[]{
            "Deception", "Manipulation", "All Talk"
        }
    );

    public static MinorTarotCard Knight => new(
        33,
        12,
        TarotSuits.Swords,
        new string[]{
            "Action", "Impulsiveness", "Defending Beliefs"
        },
        new string[]{
            "No Direction", "Disregarding Consequences", "Unpredictability"
        }
    );

    public static MinorTarotCard Queen => new(
        34,
        13,
        TarotSuits.Swords,
        new string[]{
            "Complexity", "Perceptiveness", "Clear Mindedness"
        },
        new string[]{
            "Cold Hearted", "Cruel", "Bitterness"
        }
    );

    public static MinorTarotCard King => new(
        35,
        14,
        TarotSuits.Swords,
        new string[]{
            "Head Over Heart", "Discipline", "Truth"
        },
        new string[]{
            "Manipulative", "Cruel", "Weakness"
        }
    );
}