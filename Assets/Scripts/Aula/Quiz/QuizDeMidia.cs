using System.Collections;
using UnityEngine;
using System.Linq;

public class QuizDeMidia : Quiz
{
    private FormatoDeQuizVF quizVF;
    [SerializeField] [Range(2, 4)] int quantidadeDeAfirmacoesNoQuiz;

    [Header("Formato do Quiz")][SerializeField] FormatoDeQuizVF prefabQuizVF;

    public override float TaxaDeAcerto
    {
        get { return (estado == EstadoDeQuiz.Executado)? quizVF.TaxaDeAcerto : 0; }
    }

    public Midia Midia { get; private set; }


    public void ConfigurarQuiz(Midia midia)
    {
        Midia = midia;
        quizVF = Instantiate(prefabQuizVF, canvas.transform);

        quizVF.TextoDoEnunciado = "Analise as afirmativas abaixo e selecione as corretas sobre a mídia " + midia.NomeApresentavel + ".";

        var todasAsAfirmacoes = AfirmacaoSobreMidia.ObterTodasAsAfirmacoes(midia.NomeMidia);
        var afirmacoesSelecionadas = new AfirmacaoSobreMidia[quantidadeDeAfirmacoesNoQuiz];
        for (var i = 0; i < quantidadeDeAfirmacoesNoQuiz; i++)
        {
            var afirmacoesDisponiveis = todasAsAfirmacoes.Except(afirmacoesSelecionadas);
            var indiceAleatorio = Random.Range(0, afirmacoesDisponiveis.Count());
            var afirmacaoAleatoria = afirmacoesDisponiveis.ElementAt(indiceAleatorio);
            afirmacoesSelecionadas[i] = afirmacaoAleatoria;
        }
        quizVF.DefinirAfirmacoes(afirmacoesSelecionadas);

        quizVF.IconeDoQuiz.sprite = midia.SpriteIcone;
    }

    public override IEnumerator Executar()
    {
        estado = EstadoDeQuiz.EmExecucao;

        quizVF.Mostrar();

        yield return new WaitUntil(() => quizVF.RespostaConfirmada);

        // Mostrar se o jogador acertou ou errou nas suas escolhas
        StartCoroutine(PassarTempoParaAvaliarResposta());
        yield return new WaitUntil(() => quizVF.JogadorPediuParaFechar || tempoParaAvaliarRespostaPassou);

        quizVF.Esconder();

        estado = EstadoDeQuiz.Executado;
    }
}
