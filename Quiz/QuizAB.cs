namespace temp;

public abstract class QuizAB
{
    protected abstract string[] Questions { get; }
    protected abstract string[,] Options { get; } // 2D array for flere muligheder
    protected abstract int[] CorrectAnswers { get; } // Array til at opbevare korrekte besværelse
    private static readonly Random RandomGenerator = new Random(); // random generator

    public bool StartQuiz()
    {
        try
        {
            //vælger tilfældig spørgsmål
            int questionIndex = RandomGenerator.Next(Questions.Length);

            Console.WriteLine(Questions[questionIndex]);
            //Diplayer muligheder for valgte spørgsmål
            for (int j = 0; j < 3; j++) //3 muligheder per spørgsmål
            {
                Console.WriteLine($"{j + 1}: {Options[questionIndex, j]}");
            }

            // Player's svar
            int answer = Convert.ToInt32(Console.ReadLine());

            // Checker om svaret er korrekt
            if (answer - 1 == CorrectAnswers[questionIndex]) //konverter til zero based index
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That's the correct answer!");
                Console.ResetColor();
                return true;
            }


            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Wrong answer! The correct answer was: {Options[questionIndex, CorrectAnswers[questionIndex]]}");
                Console.ResetColor();
                return false;
            }
            
        }
        //Exception der leverer en fejl meddelelse hvis man skriver forkert og giver en minus point
        catch (FormatException ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You can't choose that answer: {ex.Message}");
            Console.ResetColor();
            return false;
        }
    }

}