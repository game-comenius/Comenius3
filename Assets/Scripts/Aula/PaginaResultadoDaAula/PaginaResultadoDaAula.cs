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

    [Header("Ícones")]
    [SerializeField] GameObject midia1;
    [SerializeField] GameObject midia2;
    [SerializeField] GameObject inteligencia;
    [SerializeField] GameObject campoAprendizagem;

    [SerializeField] Sprite corporalSprite;
    [SerializeField] Sprite intrapessoalSprite;
    [SerializeField] Sprite interpessoalSprite;
    [SerializeField] Sprite linguisticaSprite;

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
        AtualizarIcones();
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

        float corVerde = pontuacaoDaAula;
        float corVermelha = 1 - corVerde;
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

        float corVerde = taxaDeAcertoNosQuizzes;
        float corVermelha = 1 - corVerde;
        barraTaxaDeAcertoNosQuizzesFill.GetComponent<Image>().color = new Color(corVermelha, corVerde, 0, 100);

    }

    private void AtualizarIcones()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        midia1.GetComponent<Image>().sprite = estadoDoJogo.MidiasSelecionadas[0].SpriteIcone;
        midia2.GetComponent<Image>().sprite = estadoDoJogo.MidiasSelecionadas[1].SpriteIcone;

        switch (estadoDoJogo.InteligenciasSelecionadas.Valor)
        {

            case 0:
                inteligencia.GetComponent<Image>().sprite = corporalSprite;
                break;

            case 1:
                inteligencia.GetComponent<Image>().sprite = intrapessoalSprite;
                break;

            case 2:
                inteligencia.GetComponent<Image>().sprite = interpessoalSprite;
                break;

            case 3:
                inteligencia.GetComponent<Image>().sprite = linguisticaSprite;
                break;

        }

        campoAprendizagem.GetComponent<Image>().sprite = estadoDoJogo.AreaDeConhecimentoSelecionada.Sprite;
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
