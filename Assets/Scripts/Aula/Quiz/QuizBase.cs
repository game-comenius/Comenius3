using UnityEngine;
using UnityEngine.UI;

// Renomerar para "Quiz" no futuro
public abstract class QuizBase : MonoBehaviour
{
    public QuizManager quizManager;
    public QuizType quizType;
    public string methodology;
    public string intelligence;
    public string intelligencePtbr;
    public string intelligenceEua;
    public string intelligenceEsp;
    public NomeDeMidia media;

    public enum QuizType
    {
        Methodology,
        MultipleIntelligences,
        Media
    }

    [TextArea]
    [SerializeReference] protected string question;
    [TextArea]
    [SerializeReference] protected string questionPtbr;
    [TextArea]
    [SerializeReference] protected string questionEua;
    [TextArea]
    [SerializeReference] protected string questionEsp;
    [SerializeReference] protected int maxAffirmations;
    [SerializeReference] protected Text questionText;
    [SerializeReference] protected bool modularText;

    protected int score;
    protected bool quizEvaluated;

    private void Start()
    {
        quizEvaluated = false;

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                question = questionEua;
                break;
            case Idiomas.PORTUGUES:
                question = questionPtbr;
                break;
            case Idiomas.ESPANHOL:
                question = questionEsp;
                break;
            default:
                break;
        }

        BuildQuiz();
    }

    public void Confirm()
    {
        if (quizEvaluated)
        {
            quizManager.NotifyQuizEnd(score);
            Destroy(gameObject);
        }
        else
        {
            Evaluate();
        }
    }

    protected virtual void BuildQuiz()
    {
        if (quizType == QuizType.MultipleIntelligences)
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    questionText.text = questionEua + intelligenceEua;
                    break;
                case Idiomas.PORTUGUES:
                    questionText.text = questionPtbr + intelligencePtbr;
                    break;
                case Idiomas.ESPANHOL:
                    questionText.text = questionEsp + intelligenceEsp;
                    break;
                default:
                    break;
            }
        }
        else if (quizType == QuizType.Media)
        {

            questionText.text = question + Midia.AtualizarTextosLinguas(new Midia(media).nomeMidia, 2);
        }
        else
        {
            questionText.text = question;
        }
    }

    protected abstract void Evaluate();
}
