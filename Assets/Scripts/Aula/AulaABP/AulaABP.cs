using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaABP : Aula
{
    // É possível definir as mídias selecionadas para a aula ABP em outra cena, são propriedades estáticas
    public static NomeMidias PrimeiraMidia;
    public static NomeMidias SegundaMidia;

    [Header("Quizzes")]
    [SerializeField] QuizDeMidia quizDeMidia1;
    [SerializeField] QuizDeMidia quizDeMidia2;
    // Após o início da cena/aula, os quizzes serão aplicados depois deste delay
    [SerializeField] [Range(0, 30)] float delayParaAplicarQuizzes;
    [SerializeField] [Range(0, 30)] float tempoEntreQuizzes;

    void Start()
    {
        // Temporário, deletar + tarde
        PrimeiraMidia = NomeMidias.Jogos;
        SegundaMidia = NomeMidias.EditoresDeTextoEPlanilhasEletronicas;

        var quizzes = ObterQuizzesConfigurados();
        StartCoroutine(AplicarQuizzes(quizzes, delayParaAplicarQuizzes, tempoEntreQuizzes));
    }

    private Quiz[] ObterQuizzesConfigurados()
    {
        // O primeiro quiz de mídia será sobre a que jogador escolheu primeiro
        quizDeMidia1.ConfigurarQuiz(PrimeiraMidia);
        // O segundo quiz de mídia será sobre a que o jogador escolheu por segundo
        quizDeMidia2.ConfigurarQuiz(SegundaMidia);

        // Ordenar os quizzes
        Quiz[] quizzes =
        {
            quizDeMidia1,
            quizDeMidia2
        };
        return quizzes;
    }

    private IEnumerator AplicarQuizzes(Quiz[] quizzes, float delayParaComecar, float tempoEntreQuizzes)
    {
        yield return new WaitForSeconds(delayParaComecar);

        for (int i = 0; i < quizzes.Length; i++)
        {
            // Executar quiz e esperar o jogador responder ele completamente
            yield return StartCoroutine(AplicarQuiz(quizzes[i]));
            // Aplicar tempo entre os quizzes (if para evitar espera após último quiz)
            if (i < quizzes.Length - 1) yield return new WaitForSeconds(tempoEntreQuizzes);
        }
    }

    protected override IEnumerator AplicarQuiz(Quiz quiz)
    {
        yield return StartCoroutine(quiz.Executar());
    }
}
