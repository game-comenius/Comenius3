using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class PaginaResultadoDaAula : MonoBehaviour
{
    [SerializeField] Text textTaxaDeAcertoDosQuizzes;

    public bool EmUso => gameObject.activeSelf;

    private void Start()
    {
        Esconder();
    }

    public void Atualizar(Quiz[] quizzesDaAula)
    {
        AtualizarTaxaDeAcertoDosQuizzes(quizzesDaAula);
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
