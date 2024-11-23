using temp;
class Metal : QuizAB
{
    protected override string[] Questions => new string[]
    {
        "En dåse af aluminium kan tage over 200 år at nedbrydes naturligt."
    };

    protected override string[,] Options => new string[,]
    {
        { "Ja", "Nej", "" }
    };

    protected override int[] CorrectAnswers => new int[] { 0 }; // Correct answer index
}