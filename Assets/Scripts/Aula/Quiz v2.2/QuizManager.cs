using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuizManager : MonoBehaviour
{
    [SerializeField] List<QuizBase> metodologyQuizList;
    [SerializeField] List<QuizBase> multipleInteligencesQuizList;
    [SerializeField] List<QuizBase> mediaQuizList;
    [SerializeField] private EstadoDeAulaInvertida stateController;

    [System.Serializable] public class ScoreChangeEvent : UnityEvent<float> { }
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

    public void NotifyQuizEnd(float correctAnswersRatio)
    {

    }
}
