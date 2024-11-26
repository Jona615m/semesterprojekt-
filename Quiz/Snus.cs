namespace temp;

class Snus : QuizAB
{
    //overrider det protected, men alle har deres egne "correct answers"
    protected override string[] Questions => new string[]
    {
        "Who/What is affected by thrown out snus",
        "Why is snus dangerous when thrown out in the nature",
        "How many snus pouches end up in the street/nature?",
    };

    protected override string[,] Options => new string[,]
    {
        { "People,", "Animals", "Plants" },
        { "Animals might mistake it for food and end up dying by nicotine poisoning", "Plants might soak up the chemicals thats snus are made of", "It might change the pH level of the ground and plants might die" },
        {"2.4 million tons", "5.3 million tons", "7.6 million tons" },
    };

    protected override int[] CorrectAnswers => new int[] {1, 0, 1 }; // Correct answers indices
}