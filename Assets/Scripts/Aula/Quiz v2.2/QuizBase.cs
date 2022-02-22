using UnityEngine;
using UnityEngine.UI;

// Renomerar para "Quiz" no futuro
public class QuizBase : MonoBehaviour
{
    public QuizType quizType;
    public string methodology;
    public string intelligence;
    public NomeDeMidia media;

    public enum QuizType
    {
        Methodology,
        MultipleIntelligences,
        Media
    }

    [TextArea]
    [SerializeReference] protected string question;
    [SerializeReference] protected QuizManager quizManager;
    [SerializeReference] protected int maxAffirmations;
    [SerializeReference] protected Text questionText;

    protected int score;
    protected bool quizEvaluated;

    private void Start()
    {
        quizEvaluated = false;
        questionText.text = question;

        BuildQuiz();
    }

    public void Confirm()
    {
        if (quizEvaluated)
            quizManager.NotifyQuizEnd(score);
        else
            Evaluate();
    }

    protected virtual void BuildQuiz() { }

    protected virtual void Evaluate() { }
}
