using temp;
class Glas : QuizAB
{
    protected override string[] Questions => new string[]
    {
        "Hvor lang tid tager det for glasflasker at nedbrydes i naturen?"
    };

    protected override string[,] Options => new string[,]
    {
        { "1 år", "50 år", "Uendeligt" }
    };

    protected override int[] CorrectAnswers => new int[] { 2 }; // Correct answer index
}