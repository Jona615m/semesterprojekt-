namespace temp;
using System;

public class Quiz
{
    public QuizAB cigaretQuiz = new Cigaret();
    public QuizAB plastikQuiz = new Plastik();
    public QuizAB elektronikQuiz = new Elektronik();
    public QuizAB metalQuiz = new Metal();
    public QuizAB glassQuiz = new Glas();
    public QuizAB snusQuiz = new Snus();

    public bool Start(string trashName)
    {

        switch (trashName.ToLower())
        {
            case "cigaret":
                return cigaretQuiz.StartQuiz();
                break;
            case "paper":
                //Not made yet
                break;
            case "plastic":
                return plastikQuiz.StartQuiz();
                break;
            case "electronic":
                return elektronikQuiz.StartQuiz();
                break;
            case "snus":
                return snusQuiz.StartQuiz();
                break;
            case "metal":
                return metalQuiz.StartQuiz();
                break;
            case "glass":
                return glassQuiz.StartQuiz();
                break;
            case "cardboard":
                //Not made yet
                break;
            default:
                throw new NotImplementedException();
        }
        throw new NotImplementedException();
    } 
    
}