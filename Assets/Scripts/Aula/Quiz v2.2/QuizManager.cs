using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> methodologyQuizList;
    [SerializeField] private List<GameObject> multipleInteligencesQuizList;
    [SerializeField] private List<GameObject> mediaQuizList;
    [SerializeField] private EstadoDeAulaInvertida stateController;
    [SerializeField] private GameObject canvas;

    [System.Serializable] public class ScoreChangeEvent : UnityEvent<int> { }
    public ScoreChangeEvent OnScoreChange;
    [System.Serializable] public class QuizEndEvent : UnityEvent { }
    public QuizEndEvent OnQuizEnd;

    public void ShowMetodologyQuiz()
    {
        GameObject quizPrefab = methodologyQuizList[Random.Range(0, methodologyQuizList.Count)];

        GameObject quiz = Instantiate(quizPrefab);

        quiz.transform.SetParent(canvas.transform);
        quiz.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        QuizSorted quizSorted = quiz.GetComponent<QuizSorted>();

        if (quizSorted != null)
        {
            quizSorted.canvas = canvas.GetComponent<Canvas>();
        }
    
        QuizBase quizBase = quiz.GetComponent<QuizBase>();
        quizBase.quizManager = this;
    }

    public void ShowMultipleInteligenceQuiz()
    {
        for(int i = 0; i < multipleInteligencesQuizList.Count; i++)
        {
            if (multipleInteligencesQuizList[i].GetComponent<QuizBase>().intelligence == EstadoDoJogo.Instance.InteligenciasSelecionadas.nome)
            {
                GameObject quiz = Instantiate(multipleInteligencesQuizList[i]);

                quiz.transform.SetParent(canvas.transform);
                quiz.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

                QuizSorted quizSorted = quiz.GetComponent<QuizSorted>();

                if (quizSorted != null)
                {
                    quizSorted.canvas = canvas.GetComponent<Canvas>();
                }

                QuizBase quizBase = quiz.GetComponent<QuizBase>();
                quizBase.quizManager = this;
            }
        }
    }

    public void ShowMediaQuiz()
    {
        for(int i = 0; i < mediaQuizList.Count; i++)
        {
            if (mediaQuizList[i].GetComponent<QuizBase>().media == stateController.midiaAtual.nomeMidia)
            {
                GameObject quiz = Instantiate(mediaQuizList[i]);

                quiz.transform.SetParent(canvas.transform);
                quiz.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

                QuizSorted quizSorted = quiz.GetComponent<QuizSorted>();

                if (quizSorted != null)
                {
                    quizSorted.canvas = canvas.GetComponent<Canvas>();
                }

                QuizBase quizBase = quiz.GetComponent<QuizBase>();
                quizBase.quizManager = this;
            }
        }
    }

    public void NotifyQuizEnd(int score)
    {
        OnQuizEnd.Invoke();
        OnScoreChange.Invoke(score);
    }
}
