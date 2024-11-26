using temp;

class Cigaret : QuizAB
{
    protected override string[] Questions => new string[]
    {
        "How long does it take for the parts of a cigarette to decompose?",
        "Around how many cigarettes are tossed daily in the nature?",
        "Can cigarettes biodegrade?",
        "Whice type of trash are most commonly seen at beaches?",
        "How long does it take for complete cigarette to decompose?",
        "How do a tossed cigarette effect the biodiversity?"
    };

    protected override string[,] Options => new string[,]
    {
        { "1-5 years for the tobacco, 10-15 years for the filter", "5-10 years for the whole cigarette", "20-30 years for all parts" },
        { "12 billions", "1 billion", "100 millions" },
        { "yes, it even happens quite fast", "No, a cigarette cant decompose", "Partially, but the filter degrades very slowly" },
        { "cigarette buds", "Plastic bottles", "Metal buckets" },
        { "10-15 years", "1 year", "100 years" },
        { "they protect the environment", "They release toxins that harms the biodiversity", "They dont have a effect at all" }
    };
    protected override int[] CorrectAnswers => new int[] { 0, 0, 2, 0, 0, 1 }; // Correct answers indices
}