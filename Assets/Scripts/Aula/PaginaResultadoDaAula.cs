using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class PaginaResultadoDaAula : MonoBehaviour
{
    [Header("Barras")]
    [SerializeField] Slider barraQualidadeDaAula;
    [SerializeField] Slider barraTaxaDeAcertoNosQuizzes;

    public bool EmUso => gameObject.activeSelf;

    private void Start()
    {
        Esconder();
    }

    public void Atualizar(float pontuacaoDaAula, Quiz[] quizzesDaAula)
    {
        AtualizarPontuacaoDaAula(pontuacaoDaAula);
        AtualizarTaxaDeAcertoNosQuizzes(quizzesDaAula);
    }

    private void AtualizarPontuacaoDaAula(float pontuacaoDaAula)
    {
        barraQualidadeDaAula.value = pontuacaoDaAula;
        //textPontuacaoDaAula.text = (pontuacaoDaAula * 100).ToString("f") + "%";
    }

    private void AtualizarTaxaDeAcertoNosQuizzes(Quiz[] quizzesDaAula)
    {
        float taxaDeAcertoNosQuizzes = 0;
        if (quizzesDaAula.Any())
            taxaDeAcertoNosQuizzes = quizzesDaAula.Sum((quiz) => quiz.TaxaDeAcerto) / quizzesDaAula.Length;
        barraTaxaDeAcertoNosQuizzes.value = taxaDeAcertoNosQuizzes;
        // Mostrar taxa de acerto nos quizzes como texto e arredondada para cima
        var textoTaxaDeAcertoNosQuizzes = barraTaxaDeAcertoNosQuizzes.GetComponentInChildren<TextMeshProUGUI>();
        var taxaDeAcertoPorcentagemArredondada = Mathf.Ceil(taxaDeAcertoNosQuizzes * 100);
        textoTaxaDeAcertoNosQuizzes.text = taxaDeAcertoPorcentagemArredondada + "%";
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
