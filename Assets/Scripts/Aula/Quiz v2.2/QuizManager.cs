using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private List<QuizBase> metodologyQuizList;
    [SerializeField] private List<QuizBase> multipleInteligencesQuizList;
    [SerializeField] private List<QuizBase> mediaQuizList;
    [SerializeField] private EstadoDeAulaInvertida stateController;

    [System.Serializable] public class ScoreChangeEvent : UnityEvent<int> { }
    public ScoreChangeEvent OnScoreChange;
    [System.Serializable] public class QuizEndEvent : UnityEvent<int> { }
    public QuizEndEvent OnQuizEnd;

    public void ShowMetodologyQuiz()
    {

    }

    public void ShowMultipleInteligenceQuiz()
    {

    }

    public void ShowMediaQuiz()
    {

    }

    public void NotifyQuizEnd(int score)
    {
        OnScoreChange.Invoke(score);
    }
}
