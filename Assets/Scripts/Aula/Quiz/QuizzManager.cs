using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizzManager : MonoBehaviour
{
    [SerializeField] Quiz[] quizzes;

    [SerializeField] EstadoDeAulaInvertida estadoDaAulaInvertida;
    private int quizzAtual = -1;



    private void Start() 
    {
        quizzAtual = -1;
    }

    public void MostrarProximoQuizz()
    {
        quizzAtual++;
        //Se acabaram os quizzes nao faz nada
        if(quizzAtual >= quizzes.Length)
            return;
        Quiz quizzParaMostrar = quizzes[quizzAtual];
        if(quizzParaMostrar  is QuizDeMidia)
        {
            QuizDeMidia quizz = (QuizDeMidia)quizzParaMostrar;
            quizz.ConfigurarQuiz(estadoDaAulaInvertida.midiaAtual);
        } else if(quizzParaMostrar  is QuizPerfilDaTurma)
        {
            QuizPerfilDaTurma quizz = (QuizPerfilDaTurma)quizzParaMostrar;
            NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
            Inteligencias inteli = EstadoDoJogo.Instance.InteligenciasSelecionadas;
            quizz.ConfigurarQuiz(nivel, inteli);
        }
        quizzParaMostrar.OnQuizzExit.RemoveAllListeners();
        StartCoroutine(quizzParaMostrar.Executar());
    }
}
