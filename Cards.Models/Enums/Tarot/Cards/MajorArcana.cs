namespace Cards.Models;

public static class MajorArcana
{
    static string ImageUrl(string card) => $"https://cdn.shopify.com/s/files/1/1325/0879/files/{card}-meaning-rider-waite-tarot-major-arcana_large.jpg";
    static string LinkUrl(string card) => $"https://labyrinthos.co/blogs/tarot-card-meanings-list/{card}-meaning-major-arcana-tarot-card-meanings";

    public static List<MajorTarotCard> Cards => new()
    {
        TheFool,
        TheMagician,
        TheHighPriestess,
        TheEmpress,
        TheEmperor,
        TheHierophant,
        TheLovers,
        TheChariot,
        Strength,
        TheHermit,
        WheelOfFortune,
        Justice,
        TheHangedMan,
        Death,
        Temperance,
        TheDevil,
        TheTower,
        TheStar,
        TheMoon,
        TheSun,
        Judgement,
        TheWorld
    };

    public static IEnumerable<MajorTarotCard> GetByAstrology(TarotAstrology astrology) =>
        Cards.Where(x => x.AstrologyId == astrology.Id);

    public static IEnumerable<MajorTarotCard> GetByElement(TarotElement element) =>
        Cards.Where(x => x.ElementId == element.Id);    


    public static MajorTarotCard TheFool => new(
        "The Fool",
        0,
        TarotPlanets.Uranus,
        TarotElements.Air,
        ImageUrl("00-the-fool"),
        LinkUrl("the-fool"),
        new string[]{
            "Innocence", "New Beginnings", "Free Spirit"
        },
        new string[]{
            "Recklessness", "Taken Advantage Of", "Inconsideration"
        }
    );

    public static MajorTarotCard TheMagician => new(
        "The Magician",
        1,
        TarotPlanets.Mercury,
        TarotElements.Air,
        ImageUrl("01-magician"),
        LinkUrl("the-magician"),
        new string[]{
            "Willpower", "Desire", "Creation", "Manifestation"
        },
        new string[]{
            "Trickery", "Illusions", "Out of Touch"
        }
    );

    public static MajorTarotCard TheHighPriestess => new(
        "The High Priestess",
        2,
        TarotPlanets.Moon,
        TarotElements.Water,
        ImageUrl("02-high-priestess"),
        LinkUrl("the-high-priestess"),
        new string[]{
            "Intuition", "Unconscious", "Inner Voice"
        },
        new string[]{
            "Lack of Center", "Lost Inner Voice", "Repressed Feelings"
        }
    );

    public static MajorTarotCard TheEmpress => new(
        "The Empress",
        3,
        TarotPlanets.Venus,
        TarotElements.Earth,
        ImageUrl("03-empress"),
        LinkUrl("the-empress"),
        new string[]{
            "Motherhood", "Fertility", "Nature"
        },
        new string[]{
            "Dependence", "Smothering", "Lack of Self-Reliance"
        }
    );

    public static MajorTarotCard TheEmperor => new(
        "The Emperor",
        4,
        TarotZodiacs.Aries,
        TarotElements.Fire,
        ImageUrl("04-emperor"),
        LinkUrl("the-emperor"),
        new string[]{
            "Authority", "Structure", "Control", "Fatherhood"
        },
        new string[]{
            "Tyranny", "Rigidity", "Coldness"
        }
    );

    public static MajorTarotCard TheHierophant => new(
        "The Hierophant",
        5,
        TarotZodiacs.Taurus,
        TarotElements.Earth,
        ImageUrl("05-hierophant"),
        LinkUrl("the-hierophant"),
        new string[]{
            "Tradition", "Conformity", "Morality & Ethics"
        },
        new string[]{
            "Rebellion", "Subversiveness", "New Approaches"
        }
    );

    public static MajorTarotCard TheLovers => new(
        "The Lovers",
        6,
        TarotZodiacs.Gemini,
        TarotElements.Air,
        ImageUrl("06-lovers"),
        LinkUrl("the-lovers"),
        new string[]{
            "Partnerships", "Union", "Duality"
        },
        new string[]{
            "Loss of Balance", "One-Sidedness", "Disharmony"
        }
    );

    public static MajorTarotCard TheChariot => new(
        "The Chariot",
        7,
        TarotZodiacs.Cancer,
        TarotElements.Water,
        ImageUrl("07-chariot"),
        LinkUrl("the-chariot"),
        new string[]{
            "Direction", "Control", "Willpower"
        },
        new string[]{
            "Lack of Control", "Lack of Direction", "Aggression"
        }
    );

    public static MajorTarotCard Strength => new(
        "Strength",
        8,
        TarotZodiacs.Leo,
        TarotElements.Fire,
        ImageUrl("08-strength"),
        LinkUrl("strength"),
        new string[]{
            "Bravery", "Compassion", "Focus", "Inner Strength"
        },
        new string[]{
            "Self Doubt", "Weakness", "Insecurity"
        }
    );

    public static MajorTarotCard TheHermit => new(
        "The Hermit",
        9,
        TarotZodiacs.Virgo,
        TarotElements.Earth,
        ImageUrl("09-hermit"),
        LinkUrl("the-hermit"),
        new string[]{
            "Contemplation", "Search for Truth", "Inner Guidance"
        },
        new string[]{
            "Loneliness", "Isolation", "Lost Your Way"
        }
    );

    public static MajorTarotCard WheelOfFortune => new(
        "Wheel of Fortune",
        10,
        TarotPlanets.Jupiter,
        TarotElements.Fire,
        ImageUrl("10-wheel-of-fortune"),
        LinkUrl("the-wheel-of-fortune"),
        new string[]{
            "Change", "Cycles", "Inevitable Fate"
        },
        new string[]{
            "No Control", "Clinging to Control", "Bad Luck"
        }
    );

    public static MajorTarotCard Justice => new(
        "Justice",
        11,
        TarotZodiacs.Libra,
        TarotElements.Air,
        ImageUrl("11-justice"),
        LinkUrl("justice"),
        new string[]{
            "Cause and Effect", "Clarity", "Truth"
        },
        new string[]{
            "Dishonesty", "Unaccountability", "Unfairness"
        }
    );

    public static MajorTarotCard TheHangedMan => new(
        "The Hanged Man",
        12,
        TarotPlanets.Neptune,
        TarotElements.Water,
        ImageUrl("12-the-hanged-man"),
        LinkUrl("the-hanged-man"),
        new string[]{
            "Sacrifice", "Release", "Martyrdom"
        },
        new string[]{
            "Stalling", "Needless Sacrifice", "Fear of Sacrifice"
        }
    );

    public static MajorTarotCard Death => new(
        "Death",
        13,
        TarotZodiacs.Scorpio,
        TarotElements.Water,
        ImageUrl("13-death"),
        LinkUrl("death"),
        new string[]{
            "End of Cycle", "New Beginnings", "Change", "Metamorphosis"
        },
        new string[]{
            "Fear of Change", "Stagnation", "Holding On"
        }
    );

    public static MajorTarotCard Temperance => new(
        "Temperance",
        14,
        TarotZodiacs.Sagittarius,
        TarotElements.Fire,
        ImageUrl("14-temperance"),
        LinkUrl("temperance"),
        new string[]{
            "Middle Path", "Patience", "Finding Meaning"
        },
        new string[]{
            "Extremes", "Excess", "Lack of Balance"
        }
    );

    public static MajorTarotCard TheDevil => new(
        "The Devil",
        15,
        TarotZodiacs.Capricorn,
        TarotElements.Earth,
        ImageUrl("15-devil"),
        LinkUrl("the-devil"),
        new string[]{
            "Excess", "Materialism", "Playfulness"
        },
        new string[]{
            "Freedom", "Release", "Restoring Control"
        }
    );

    public static MajorTarotCard TheTower => new(
        "The Tower",
        16,
        TarotPlanets.Mars,
        TarotElements.Fire,
        ImageUrl("16-tower"),
        LinkUrl("the-tower"),
        new string[]{
            "Sudden Upheaval", "Broken Pride", "Disaster"
        },
        new string[]{
            "Disaster Avoided", "Delaying Disaster", "Fear of Suffering"
        }
    );

    public static MajorTarotCard TheStar => new(
        "The Star",
        17,
        TarotZodiacs.Aquarius,
        TarotElements.Air,
        ImageUrl("17-star"),
        LinkUrl("the-star"),
        new string[]{
            "Hope", "Faith", "Rejuvenation"
        },
        new string[]{
            "Insecurity", "Discouragement", "Faithlessness"
        }
    );

    public static MajorTarotCard TheMoon => new(
        "The Moon",
        18,
        TarotZodiacs.Pisces,
        TarotElements.Water,
        ImageUrl("18-moon"),
        LinkUrl("the-moon"),
        new string[]{
            "Unconscious", "Illusions", "Intuition"
        },
        new string[] {
            "Confusion", "Fear", "Misinterpretation"
        }
    );

    public static MajorTarotCard TheSun => new(
        "The Sun",
        19,
        TarotPlanets.Sun,
        TarotElements.Fire,
        ImageUrl("19-sun"),
        LinkUrl("the-sun"),
        new string[]{
            "Joy", "Success", "Celebration"
        },
        new string[]{
            "Negativity", "Depression", "Sadness"
        }
    );

    public static MajorTarotCard Judgement => new(
        "Judgement",
        20,
        TarotPlanets.Pluto,
        TarotElements.Fire,
        ImageUrl("20-judgment"),
        LinkUrl("judgement"),
        new string[]{
            "Reflection", "Reckoning", "Awakening"
        },
        new string[]{
            "No Self Awareness", "Doubt", "Self Loathing"
        }
    );

    public static MajorTarotCard TheWorld => new(
        "The World",
        21,
        TarotPlanets.Saturn,
        TarotElements.Earth,
        ImageUrl("21-the-world"),
        LinkUrl("the-world"),
        new string[]{
            "Fulfillment", "Harmony", "Completion"
        },
        new string[]{
            "Incompletion", "No Closure", "Emptiness"
        }
    );
}