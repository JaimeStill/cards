namespace Cards.Models;

public static class TarotPlanets
{
    public static TarotPlanet Jupiter => new(
        "Jupiter",
        "Every 12 - 13 Months",
        new TarotZodiac[]{ TarotZodiacs.Sagittarius },
        "Luck", "Growth", "Expansion",
        "Optimism", "Abundance",
        "Understanding"
    );

    public static TarotPlanet Mars => new(
        "Mars",
        "Every 6 - 7 Weeks",
        new TarotZodiac[]{ TarotZodiacs.Aries },
        "Aggression", "Sex", "Action", "Desire",
        "Competition", "Courage", "Passion"
    );

    public static TarotPlanet Mercury => new(
        "Mercury",
        "Every 3 - 4 Weeks",
        new TarotZodiac[]{ TarotZodiacs.Gemini, TarotZodiacs.Virgo },
        "Mind", "Communication", "Intellect",
        "Reason", "Language", "Intelligence"
    );

    public static TarotPlanet Moon => new(
        "Moon",
        "Every 2 - 3 Days",
        new TarotZodiac[]{ TarotZodiacs.Cancer },
        "Unconsciousness", "Emotions", "Instincts",
        "Habits", "Moods"
    );

    public static TarotPlanet Neptune => new(
        "Neptune",
        "Every 10 - 12 Years",
        new TarotZodiac[]{ TarotZodiacs.Pisces },
        "Dreams", "Intuition", "Mysticism",
        "Imagination", "Delusions"
    );

    public static TarotPlanet Pluto => new(
        "Pluto",
        "Every 12 - 15 Years",
        new TarotZodiac[]{ TarotZodiacs.Scorpio },
        "Transformation", "Power", "Death",
        "Rebirth", "Evolution"
    );

    public static TarotPlanet Saturn => new(
        "Saturn",
        "Every 2 - 3 Years",
        new TarotZodiac[]{ TarotZodiacs.Capricorn },
        "Structure", "Law", "Restriction",
        "Discipline", "Responsiblity",
        "Obligation", "Ambition"
    );

    public static TarotPlanet Sun => new(
        "Sun",
        "Every Month",
        new TarotZodiac[]{ TarotZodiacs.Leo },
        "Ego", "Basic Personality", "Consciousness",
        "Vitality", "Stamina"
    );

    public static TarotPlanet Uranus => new(
        "Uranus",
        "Every 7 Years",
        new TarotZodiac[]{ TarotZodiacs.Aquarius },
        "Eccentricity", "Unpredictable Changes",
        "Rebellion", "Reformation"
    );

    public static TarotPlanet Venus => new(
        "Venus",
        "Every 4 - 5 Weeks",
        new TarotZodiac[]{ TarotZodiacs.Taurus, TarotZodiacs.Libra },
        "Attraction", "Love", "Relationships",
        "Art", "Beauty", "Harmony"
    );
}