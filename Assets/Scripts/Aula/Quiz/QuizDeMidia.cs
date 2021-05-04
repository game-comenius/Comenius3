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

        quizVF.TextoDoEnunciado = "Analise as afirmativas abaixo e selecione a(s) correta(s) sobre a mídia " + midia.NomeApresentavel + ".";

        var todasAsAfirmacoes = AfirmacaoSobreMidia.ObterTodasAsAfirmacoes(midia.NomeMidia);
        var afirmacoesSelecionadas = new AfirmacaoSobreMidia[quantidadeDeAfirmacoesNoQuiz];

        // Selecionar pelo menos uma afirmação verdadeira
        var afirmacoesVerdadeiras = todasAsAfirmacoes.Where(a => a.Verdadeira);
        var indiceAleatorio = Random.Range(0, afirmacoesVerdadeiras.Count());
        afirmacoesSelecionadas[0] = afirmacoesVerdadeiras.ElementAt(indiceAleatorio);

        // Selecionar as outras afirmações do quiz, que podem ou não serem verdadeiras
        for (var i = 1; i < quantidadeDeAfirmacoesNoQuiz; i++)
        {
            var afirmacoesDisponiveis = todasAsAfirmacoes.Except(afirmacoesSelecionadas);
            indiceAleatorio = Random.Range(0, afirmacoesDisponiveis.Count());
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
