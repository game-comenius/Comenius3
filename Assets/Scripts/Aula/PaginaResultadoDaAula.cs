using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class PaginaResultadoDaAula : MonoBehaviour
{
    [SerializeField] Text textPontuacaoDaAula;
    [SerializeField] Text textTaxaDeAcertoDosQuizzes;

    public bool EmUso => gameObject.activeSelf;

    private void Start()
    {
        Esconder();
    }

    public void Atualizar(float pontuacaoDaAula, Quiz[] quizzesDaAula)
    {
        AtualizarPontuacaoDaAula(pontuacaoDaAula);
        AtualizarTaxaDeAcertoDosQuizzes(quizzesDaAula);
    }

    private void AtualizarPontuacaoDaAula(float pontuacaoDaAula)
    {
        textPontuacaoDaAula.text = (pontuacaoDaAula * 100).ToString("f") + "%";
    }

    private void AtualizarTaxaDeAcertoDosQuizzes(Quiz[] quizzesDaAula)
    {
        float taxaDeAcertoDosQuizzes = 0;
        if (quizzesDaAula.Any())
            taxaDeAcertoDosQuizzes = quizzesDaAula.Sum((quiz) => quiz.TaxaDeAcerto) / quizzesDaAula.Length;
        textTaxaDeAcertoDosQuizzes.text = (taxaDeAcertoDosQuizzes * 100).ToString("f") + "%";
    }

    public void Mostrar()
    {
        gameObject.SetActive(true);
    }

    public void Esconder()
    {
        gameObject.SetActive(false);
    }
}
