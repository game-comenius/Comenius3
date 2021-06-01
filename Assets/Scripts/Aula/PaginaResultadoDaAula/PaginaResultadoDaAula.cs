using System;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class PaginaResultadoDaAula : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI feedbackDaLurdinhaTextComponent;
    [SerializeField] GameObject balaoFeedbackDosAlunos;

    [Header("Barras")]
    [SerializeField] Slider barraQualidadeDaAula;
    [SerializeField] Slider barraTaxaDeAcertoNosQuizzes;

    [SerializeField] Image barraQualidadeDaAulaFill;
    [SerializeField] Image barraTaxaDeAcertoNosQuizzesFill;

    public bool EmUso => gameObject.activeSelf;

    private void Start()
    {
        Esconder();
    }

    public void Atualizar(float pontuacaoDaAula, Quiz[] quizzesDaAula)
    {
        AtualizarFeedbackDaLurdinha();
        AtualizarFeedbackDosAlunos();
        AtualizarPontuacaoDaAula(pontuacaoDaAula);
        AtualizarTaxaDeAcertoNosQuizzes(quizzesDaAula);
    }

    private void AtualizarFeedbackDaLurdinha()
    {
        var listaDeFeedback = FeedbackDaLurdinha.ObterFeedback(EstadoDoJogo.Instance);
        var feedbackCompleto = string.Join("\n\n", listaDeFeedback);
        feedbackDaLurdinhaTextComponent.text = feedbackCompleto;
    }

    private void AtualizarFeedbackDosAlunos()
    {
        var textComponents = balaoFeedbackDosAlunos.GetComponentsInChildren<TextMeshProUGUI>();
        var textComponentFeedback = textComponents[0];
        var textComponentAssinatura = textComponents[1];

        var (feedbackDoAluno, assinatura) = FeedbackDosAlunos.ObterFeedback(EstadoDoJogo.Instance);

        // Colocar àspas ao redor do feedback do aluno
        feedbackDoAluno = $"\"{feedbackDoAluno}\"";
        textComponentFeedback.text = feedbackDoAluno;

        if (assinatura != null)
        {
            textComponentAssinatura.gameObject.SetActive(true);
            textComponentAssinatura.text = assinatura;
        }
        else
        {
            // Se ninguém assinou, esconder o GameObject da assinatura
            textComponentAssinatura.gameObject.SetActive(false);
        }

    }

    private void AtualizarPontuacaoDaAula(float pontuacaoDaAula)
    {
        barraQualidadeDaAula.value = pontuacaoDaAula;

        float corVermelha = 1f;
        float corVerde = 1f;

        switch (pontuacaoDaAula)
        {
            case float pontuacao when pontuacao >= 0.75:
                corVermelha = 0f;
                corVerde = 1f;
                break;
            case float pontuacao when pontuacao >= 0.50:
                corVermelha = 0.65f;
                corVerde = 1f;
                break;
            case float pontuacao when pontuacao >= 0.25:
                corVermelha = 1f;
                corVerde = 1f;
                break;
            default:
                corVermelha = 1f;
                corVerde = 0f;
                break;
        }

        barraQualidadeDaAulaFill.GetComponent<Image>().color = new Color(corVermelha, corVerde, 0, 100);
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

        float corVermelha = 1f;
        float corVerde = 1f;

        switch (taxaDeAcertoNosQuizzes)
        {
            case float pontuacao when pontuacao >= 0.75:
                corVermelha = 0f;
                corVerde = 1f;
                break;
            case float pontuacao when pontuacao >= 0.50:
                corVermelha = 0.65f;
                corVerde = 1f;
                break;
            case float pontuacao when pontuacao >= 0.25:
                corVermelha = 1f;
                corVerde = 1f;
                break;
            default:
                corVermelha = 1f;
                corVerde = 0f;
                break;
        }

        barraTaxaDeAcertoNosQuizzesFill.GetComponent<Image>().color = new Color(corVermelha, corVerde, 0, 100);

    }

    public void Mostrar()
    {
        //Começar trilha dos créditos
        var creditosTrilha = AudioManager.instance.creditosTrilha;
        AudioManager.instance.CriacaoGameObjectTrilhaSonora(creditosTrilha);
        gameObject.SetActive(true);
    }

    public void Esconder()
    {
        gameObject.SetActive(false);
    }
}
