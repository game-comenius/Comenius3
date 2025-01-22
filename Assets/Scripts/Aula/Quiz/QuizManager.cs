using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuizManager : MonoBehaviour
{
    [System.Serializable] public class ScoreChangeEvent : UnityEvent<int> { }
    public ScoreChangeEvent OnScoreChange;
    [System.Serializable] public class QuizEndEvent : UnityEvent { }
    public QuizEndEvent OnQuizEnd;

    [SerializeField] private List<GameObject> methodologyQuizList;
    [SerializeField] private List<GameObject> multipleInteligencesQuizList;
    [SerializeField] private List<GameObject> mediaQuizList;
    [SerializeField] private StateMachineController stateMachine;
    [SerializeField] private GameObject canvas;

    public void ShowMetodologyQuiz()
    {
        GameObject quizPrefab = methodologyQuizList[Random.Range(0, methodologyQuizList.Count)];

        GameObject quiz = Instantiate(quizPrefab);

        quiz.transform.SetParent(canvas.transform, false);
        quiz.transform.SetAsFirstSibling();
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
        Debug.Log("Cheguei até aqui");
        Inteligencias.AtualizarTextosLinguas();
        for (int i = 0; i < multipleInteligencesQuizList.Count; i++)
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:

                    if (multipleInteligencesQuizList[i].GetComponent<QuizBase>().intelligenceEua == EstadoDoJogo.Instance.Inteligencias.nome)
                    {
                        GameObject quiz = Instantiate(multipleInteligencesQuizList[i]);

                        quiz.transform.SetParent(canvas.transform);
                        quiz.transform.SetAsFirstSibling();
                        quiz.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

                        QuizSorted quizSorted = quiz.GetComponent<QuizSorted>();

                        if (quizSorted != null)
                        {
                            quizSorted.canvas = canvas.GetComponent<Canvas>();
                        }

                        QuizBase quizBase = quiz.GetComponent<QuizBase>();
                        quizBase.quizManager = this;

                        break;
                    }
                    break;
                case Idiomas.PORTUGUES:
                    if (multipleInteligencesQuizList[i].GetComponent<QuizBase>().intelligencePtbr == EstadoDoJogo.Instance.Inteligencias.nome)
                    {
                        GameObject quiz = Instantiate(multipleInteligencesQuizList[i]);

                        quiz.transform.SetParent(canvas.transform);
                        quiz.transform.SetAsFirstSibling();
                        quiz.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

                        QuizSorted quizSorted = quiz.GetComponent<QuizSorted>();

                        if (quizSorted != null)
                        {
                            quizSorted.canvas = canvas.GetComponent<Canvas>();
                        }

                        QuizBase quizBase = quiz.GetComponent<QuizBase>();
                        quizBase.quizManager = this;

                        break;
                    }
                    break;
                case Idiomas.ESPANHOL:
                    if (multipleInteligencesQuizList[i].GetComponent<QuizBase>().intelligenceEsp == EstadoDoJogo.Instance.Inteligencias.nome)
                    {
                        GameObject quiz = Instantiate(multipleInteligencesQuizList[i]);

                        quiz.transform.SetParent(canvas.transform);
                        quiz.transform.SetAsFirstSibling();
                        quiz.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

                        QuizSorted quizSorted = quiz.GetComponent<QuizSorted>();

                        if (quizSorted != null)
                        {
                            quizSorted.canvas = canvas.GetComponent<Canvas>();
                        }

                        QuizBase quizBase = quiz.GetComponent<QuizBase>();
                        quizBase.quizManager = this;

                        break;
                    }
                    break;
                default:
                    break;
            }
          
        }
    }
    public void ShowMediaQuiz()
    {
        Debug.Log(stateMachine.CurrentMedia());
        for (int i = 0; i < mediaQuizList.Count; i++)
        {
            if (mediaQuizList[i].GetComponent<QuizBase>().media == stateMachine.CurrentMedia().nomeMidia)
            {
                GameObject quiz = Instantiate(mediaQuizList[i]);

                quiz.transform.SetParent(canvas.transform);
                quiz.transform.SetAsFirstSibling();
                quiz.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

                QuizSorted quizSorted = quiz.GetComponent<QuizSorted>();

                if (quizSorted != null)
                {
                    quizSorted.canvas = canvas.GetComponent<Canvas>();
                }

                QuizBase quizBase = quiz.GetComponent<QuizBase>();
                quizBase.quizManager = this;

                break;
            }
        }
    }

    public void NotifyQuizEnd(int score)
    {
        OnQuizEnd.Invoke();
        OnScoreChange.Invoke(score);
    }
}
