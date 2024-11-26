using temp;
class Metal : QuizAB
{
    protected override string[] Questions => new string[]
    {
        "Can an aluminum can take over 200 years to decompose naturally?"
    };

    protected override string[,] Options => new string[,]
    {
        { "Yes", "No", "It doesn't decompose" }
    };

    protected override int[] CorrectAnswers => new int[] { 0 };  //Correct answer index
}