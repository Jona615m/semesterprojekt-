using temp;

class Cigaret : QuizAB
{
    protected override string[] Questions => new string[]
    {
        "Hvor lang tid tager det for en cigaret at blive nedbrudt?",
        "Hvor mange cigaretter bliver cirka smidt ud i naturen hver dag?",
        "Kan cigaretter blive biologisk nedbrudt?",
        "Hvilken type affald finder man mest på strande på verdensplan?",
        "Hvor lang tid tager det for et cigaretskod at blive nedbrudt?",
        "Hvordan påvirker cigaretskod økosystemer og dyreliv?"
    };

    protected override string[,] Options => new string[,]
    {
        { "1-5 år for tobakken, 10-15 år for filteret", "5-10 år for hele cigaretten", "20-30 år for begge dele" },
        { "12 milliarder", "1 milliard", "100 millioner" },
        { "Ja, hurtigt", "Nej, de kan ikke nedbrydes", "Delvist, men filteret nedbrydes meget langsomt" },
        { "Cigaretskod", "Plastikflasker", "Metalspande" },
        { "10-15 år", "1 år", "100 år" },
        { "De beskytter miljøet", "De frigiver toksiner, som skader dyreliv og planter", "De har ingen effekt" }
    };

    protected override int[] CorrectAnswers => new int[] { 0, 0, 2, 0, 0, 1 }; // Correct answers indices
}