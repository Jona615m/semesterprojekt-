namespace temp;

public abstract class QuizAB
{
        protected abstract string[] Questions { get; }
        protected abstract string[,] Options { get; } // 2D array for multiple options
        protected abstract int[] CorrectAnswers { get; } // Array to store correct answer indices

        private static readonly Random RandomGenerator = new Random(); // Shared random generator

        public string StartQuiz()
        {
            // Randomly select a question
            int questionIndex = RandomGenerator.Next(Questions.Length);

            Console.WriteLine(Questions[questionIndex]);

            // Display options for the selected question
            for (int j = 0; j < 3; j++) //3 options per question
            {
                Console.WriteLine($"{j + 1}: {Options[questionIndex, j]}");
            }

            // Player's answer
            int answer = Convert.ToInt32(Console.ReadLine());

            // Check if the answer is correct
            if (answer - 1 == CorrectAnswers[questionIndex]) // Convert to zero-based index
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That's the correct answer!");
                Console.ResetColor();
                /*Program.UpdateScore(100); // Add +100 to global score*/
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Bummer, wrong answer! The correct answer was: {Options[questionIndex, CorrectAnswers[questionIndex]]}");
                Console.ResetColor();
                /*Program.Point(-100); // Subtract 100 from global score*/
            }

            return "Quiz ended.";
        }
}