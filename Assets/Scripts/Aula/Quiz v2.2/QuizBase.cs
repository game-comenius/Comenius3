using UnityEngine;
using UnityEngine.UI;

// Renomerar para "Quiz" no futuro
public class QuizBase : MonoBehaviour
{
    public QuizType quizType;
    public enum QuizType
    {
        Metodology,
        MultipleInteligences,
        Media
    }

    [SerializeReference] protected QuizManager quizManager;
    [SerializeReference] protected int maxAffirmations;
    [SerializeReference] protected Image icon;
    [SerializeReference] protected Text question;

    protected float correctAnswersRatio;
    protected bool quizEvaluated;

    private void Start()
    {
        quizEvaluated = false;

        BuildQuiz();
    }

    public void Confirm()
    {
        if (quizEvaluated)
            quizManager.NotifyQuizEnd(correctAnswersRatio);
        else
            Evaluate();
    }

    protected virtual void BuildQuiz() { }

    protected virtual void Evaluate() { }
}
