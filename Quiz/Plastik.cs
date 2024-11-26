using temp;
class Plastik : QuizAB
{
    //overrider det protected, men alle har deres egne "correct answers"
    protected override string[] Questions => new string[]
    {
        "How much plastic ends up in the ocean each year?",
        "Whice type of garbage is the threat to animals?",
        "How long does it take for a single plastic bottle to decompose?",
        "How much plastic is thrown out without being recycled each year?",
        "What happens with the plastic that ends up in the nature?"
    };

    protected override string[,] Options => new string[,]
    {
        { "8-10 millions ton", "1-2 millions ton", "50 millions ton" },
        { "Cigarette buds", "Plastic", "Paper" },
        { "5-10 years", "50-100 years", "Up to 500 years" },
        { "300 millions ton", "50 millions ton", "1 billion ton" },
        { "It completely decomposes", "It breaks down to microplastics, which pollutes", "It disappears quickly " }
    };

    protected override int[] CorrectAnswers => new int[] { 0, 1, 1, 0, 1 }; // Correct answers indices
}