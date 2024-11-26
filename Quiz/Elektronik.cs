using temp;
class Elektronik : QuizAB
{
    protected override string[] Questions => new string[]
    {
        "How long does it take for a battery to decompose?",
        "What is the biggest danger by throwing your trash in nature?",
        "What is the biggest environmental impact of electronic waste?",
        "How long does it typically take for electronics such as mobile phones and computers to degrade in nature?",
        "How can consumers help reduce electronic waste?"
    };

    protected override string[,] Options => new string[,]
    {
        { "1 year", "10 years", "100 years" },
        { "Pollution of the air", "Damage to wildlife and ecosystems", "Pollution of the earth's surface" },
        { "Parts of a battery", "PCB-polution", "Plastic waste" },
        { "5 years", "50 years", "100 years" },
        { "Recycle", "Buy less electronics", "Use more electronics" },
    };

    protected override int[] CorrectAnswers => new int[] { 2, 1, 1, 2, 0 }; // Correct answers indices
}