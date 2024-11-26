using temp;
class Glas : QuizAB
{
        protected override string[] Questions => new string[]
        {
            "How long does it take for glass bottles to decompose in nature?"
        };

        protected override string[,] Options => new string[,]
        {
            { "1 year", "50 years", "It can't decompose naturally" }
        };

        protected override int[] CorrectAnswers => new int[] { 2 }; // Correct answer index
}