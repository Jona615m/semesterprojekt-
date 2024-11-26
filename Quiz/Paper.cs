namespace temp;

class Paper : QuizAB
{
    //overrider det protected, men alle har deres egne "correct answers"
    protected override string[] Questions => new string[]
    {
        "How much total waste does paper account for landfills?",
        "How much wood is cut down for paper production?",
        "How does paper affect nature when it is not sorted correctly?",
        "How long does it take for cardboard to decompose?",
        "How long does it take for paper to decompose?",
    };

    protected override string[,] Options => new string[,]
    {
        { "15%" , "59%" , "26%" },  
        { "8 to 10 billion trees" , "20 billion trees" , "4 to 8 billion trees" },
        { "air", "water and land pollution", "Improved plant growth"},
        { "5 months", "2 months", "12 months" },
        { "2 to 6 weeks", "6 to 10 weeks", "10 to 14 weeks" }
    };

    protected override int[] CorrectAnswers => new int[] {2, 2, 0, 1, 0}; // Correct answers indices
}