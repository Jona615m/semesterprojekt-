namespace temp;
using System;

public class Quiz
{
    public QuizAB cigaretQuiz = new Cigaret();
    public QuizAB plastikQuiz = new Plastik();
    public QuizAB elektronikQuiz = new Elektronik();
    public QuizAB metalQuiz = new Metal();
    public QuizAB glassQuiz = new Glas();

    public void Start(string trashName) {

        switch (trashName.ToLower()) {
            case "cigaret":
                cigaretQuiz.StartQuiz();
                break;
            case "paper":
                //Not made yet
                break;
            case "plastic":
                plastikQuiz.StartQuiz();
                break;
            case "electronic":
                elektronikQuiz.StartQuiz();
                break;
            case "snus":
                //Not made yet
                break;
            case "metal":
                metalQuiz.StartQuiz();
                break;
            case "glass":
                glassQuiz.StartQuiz();
                break;
            case "cardboard":
                //Not made yet
                break;
            default:
                throw new NotImplementedException();
        }

    }
}