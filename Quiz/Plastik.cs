using temp;
class Plastik : QuizAB
{
    //overrider det protected, men alle har deres egne "correct answers"
    protected override string[] Questions => new string[]
    {
        "Hvor meget plastik ender ude i havet hvert år?",
        "Hvilken type affald er den største trussel til dyreliv?",
        "Hvor lang tid tager det for plastikflasker at blive nedbrudt?",
        "Hvor meget plast affald smides væk globalt hvert år?",
        "Hvad sker der med plast der forvitrer i naturen?"
    };

    protected override string[,] Options => new string[,]
    {
        { "8-10 millioner tons", "1-2 millioner tons", "50 millioner tons" },
        { "Cigaretskod", "Plastik", "Papir" },
        { "5-10 år", "50-100 år", "Op til 500 år" },
        { "300 millioner tons", "50 millioner tons", "1 milliard tons" },
        { "Det bliver helt nedbrudt", "Det fragmenteres til mikroplast, som forurener", "Det forsvinder hurtigt" }
    };

    protected override int[] CorrectAnswers => new int[] { 0, 1, 1, 0, 1 }; // Correct answers indices
}