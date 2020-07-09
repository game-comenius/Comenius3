using System.Collections;
using UnityEngine;
using System.Linq;

public class QuizDeMidia : Quiz
{
    [SerializeField] FormatoDeQuizVF prefabQuizVF;
    private FormatoDeQuizVF quizVF;
    [SerializeField] [Range(2, 4)] int quantidadeDeAfirmacoesNoQuiz;

    public override float TaxaDeAcerto
    {
        get { return (estado == EstadoDeQuiz.Executado)? quizVF.TaxaDeAcerto: 0; }
    }

    public NomeMidias Midia { get; private set; }


    public void ConfigurarQuiz(NomeMidias midia)
    {
        Midia = midia;
        quizVF = Instantiate(prefabQuizVF, canvas.transform);

        quizVF.TextoDoEnunciado = "Selecione as afirmações corretas sobre a mídia " + new Midia(midia).NomeApresentavel + ".";

        var todasAsAfirmacoes = AfirmacaoSobreMidia.ObterTodasAsAfirmacoes(midia);
        var afirmacoesSelecionadas = new AfirmacaoSobreMidia[quantidadeDeAfirmacoesNoQuiz];
        for (var i = 0; i < quantidadeDeAfirmacoesNoQuiz; i++)
        {
            var afirmacoesDisponiveis = todasAsAfirmacoes.Except(afirmacoesSelecionadas);
            var indiceAleatorio = Random.Range(0, afirmacoesDisponiveis.Count());
            var afirmacaoAleatoria = afirmacoesDisponiveis.ElementAt(indiceAleatorio);
            afirmacoesSelecionadas[i] = afirmacaoAleatoria;
        }
        quizVF.DefinirAfirmacoes(afirmacoesSelecionadas);
    }

    public override IEnumerator Executar()
    {
        estado = EstadoDeQuiz.EmExecucao;
        Debug.Log("Executando quiz de mídia...");

        quizVF.Mostrar();
        yield return new WaitForSeconds(tempoLimite);
        quizVF.Esconder();

        Debug.Log("Terminando a execução do quiz de mídia...");
        estado = EstadoDeQuiz.Executado;
    }
}
