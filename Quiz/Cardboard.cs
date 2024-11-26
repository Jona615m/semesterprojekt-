namespace temp;

class Cardboard : QuizAB
{
    //overrider det protected, men alle har deres egne "correct answers"
    protected override string[] Questions => new string[]
    {
     
    };

    protected override string[,] Options => new string[,]
    {
   
    };

    protected override int[] CorrectAnswers => new int[] { }; // Correct answers indices
}