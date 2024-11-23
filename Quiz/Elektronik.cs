using temp;
class Elektronik : QuizAB
{
    protected override string[] Questions => new string[]
    {
        "Hvor lang tid tager det for et batteri at blive nedbrudt i naturen?",
        "Hvad er den største miljømæssige risiko ved at smide affald i naturen?",
        "Hvad er den største miljøpåvirkning af elektronikaffald?",
        "Hvor lang tid tager det typisk for elektronik såsom mobiltelefoner og computere at nedbrydes i naturen?",
        "Hvordan kan man som forbrugere hjælpe med at reducere elektronikaffald?"
    };

    protected override string[,] Options => new string[,]
    {
        { "1 år", "10 år", "100 år" },
        { "Forurening af luft", "Skader på dyreliv og økosystemer", "Forurening af jordens overflade" },
        { "Dele af batterier", "PCB-forurening", "Plastic affald" },
        { "5 år", "50 år", "100 år" },
        { "Genbrug", "Køb mindre elektronik", "Brug mere elektronik" }
    };

    protected override int[] CorrectAnswers => new int[] { 2, 1, 1, 2, 0 }; // Correct answers indices
}