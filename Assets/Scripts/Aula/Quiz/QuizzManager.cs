using UnityEngine;
using UnityEngine.Events;

public class QuizzManager : MonoBehaviour
{
    [SerializeField] private Quiz[] quizzes;

    [SerializeField] private EstadoDeAulaInvertida estadoDaAulaInvertida;
    private int quizzAtual = -1;

    [System.Serializable] public class QuizzExitEvent : UnityEvent<float> { }
    public QuizzExitEvent OnPontuacaoChange;
    [System.Serializable] public class QuizzEndEvent : UnityEvent<int> { }
    public QuizzExitEvent OnQuizzEnd;

    private void Start()
    {
        quizzAtual = -1;

        foreach (Quiz quiz in quizzes)
        {
            quiz.OnQuizzExit.AddListener(EndQuizz);
        }
    }

    private void OnDestroy()
    {
        foreach (Quiz quiz in quizzes)
        {
            quiz.OnQuizzExit.RemoveListener(EndQuizz);
        }
    }

    public void MostrarProximoQuizz()
    {
        quizzAtual++;
        //Se acabaram os quizzes nao faz nada
        if (quizzAtual >= quizzes.Length)
            return;
        Quiz quizzParaMostrar = quizzes[quizzAtual];
        if (quizzParaMostrar is QuizDeMidia)
        {
            QuizDeMidia quizz = (QuizDeMidia)quizzParaMostrar;
            quizz.ConfigurarQuiz(estadoDaAulaInvertida.midiaAtual);
        }
        else if (quizzParaMostrar is QuizPerfilDaTurma)
        {
            QuizPerfilDaTurma quizz = (QuizPerfilDaTurma)quizzParaMostrar;
            NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
            Inteligencias inteli = EstadoDoJogo.Instance.InteligenciasSelecionadas;
            quizz.ConfigurarQuiz(nivel, inteli);
        }
        quizzParaMostrar.OnQuizzExit.RemoveAllListeners();
        StartCoroutine(quizzParaMostrar.Executar());
    }

    public void EndQuizz(float taxaDeAcerto)
    {
        int quantidadeDeQuizzes = quizzes.Length;
        float tamanhoDoFragmento = taxaDeAcerto / quantidadeDeQuizzes;
        OnPontuacaoChange.Invoke(tamanhoDoFragmento);

        OnQuizzEnd.Invoke(quantidadeDeQuizzes);
    }
}
