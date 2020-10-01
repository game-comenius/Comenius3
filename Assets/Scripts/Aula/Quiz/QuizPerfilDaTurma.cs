using System.Collections;
using UnityEngine;

public class QuizPerfilDaTurma : Quiz
{
    [Header("Formato do Quiz")] [SerializeField] FormatoDeQuizVF prefabQuizVF;
    private FormatoDeQuiz formatoDoQuiz;

    public NivelDeEnsino NivelDeEnsino { get; set; }
    public Inteligencias Inteligencias { get; set; }

    private int quantidadeDeAfirmacoesNoQuiz = 4;

    public override float TaxaDeAcerto
    {
        get { return (estado == EstadoDeQuiz.Executado) ? formatoDoQuiz.TaxaDeAcerto : 0; }
    }

    public void ConfigurarQuiz(NivelDeEnsino nivelDeEnsino, Inteligencias inteligencias)
    {
        Afirmacao[] afirmacoesDisponiveis;
        string enunciadoDoQuiz;

        // Sorteio entre 0 e 1.
        // Se sair 0, o quiz será sobre nível de ensino
        // Se sair 1, o quiz será sobre Inteligências Múltiplas
        //int zeroOuUm = Random.Range(0, 2);
        int zeroOuUm = 1;
        if (zeroOuUm == 0)
        {
            this.NivelDeEnsino = nivelDeEnsino;
            enunciadoDoQuiz = "Analise as afirmativas abaixo e selecione as corretas sobre " + nivelDeEnsino.nome;
            afirmacoesDisponiveis = AfirmacaoSobreNivelDeEnsino.ObterTodasAsAfirmacoes(nivelDeEnsino);
        }
        else // ZeroOuUm == 1
        {
            this.Inteligencias = inteligencias;
            enunciadoDoQuiz = "Analise as afirmativas abaixo e selecione as corretas sobre o par de inteligências " + inteligencias.Nome;
            afirmacoesDisponiveis = AfirmacaoSobreInteligencias.ObterTodasAsAfirmacoes(inteligencias);
        }

        // Embaralhar as afirmações usando algoritmo Fisher–Yates Shuffle, O(n)
        for (int i = afirmacoesDisponiveis.Length - 1; i > 0; i--)
        {
            var randomIndex = Random.Range(0, i + 1);
            var temp = afirmacoesDisponiveis[randomIndex];
            afirmacoesDisponiveis[randomIndex] = afirmacoesDisponiveis[i];
            afirmacoesDisponiveis[i] = temp;
        }

        // Selecionar algumas dessas afirmações para colocar no quiz
        var afirmacoesDoQuiz = new Afirmacao[quantidadeDeAfirmacoesNoQuiz];
        for (int i = 0; i < quantidadeDeAfirmacoesNoQuiz; i++)
            afirmacoesDoQuiz[i] = afirmacoesDisponiveis[i];

        formatoDoQuiz = Instantiate(prefabQuizVF, canvas.transform);
        formatoDoQuiz.TextoDoEnunciado = enunciadoDoQuiz;
        formatoDoQuiz.DefinirAfirmacoes(afirmacoesDoQuiz);
    }

    // Chamar método ConfigurarQuiz antes deste método
    public override IEnumerator Executar()
    {
        estado = EstadoDeQuiz.EmExecucao;

        formatoDoQuiz.Mostrar();

        yield return new WaitUntil(() => formatoDoQuiz.RespostaConfirmada);

        // Mostrar se o jogador acertou ou errou nas suas escolhas
        yield return new WaitForSeconds(tempoParaAvaliarResposta);

        formatoDoQuiz.Esconder();

        estado = EstadoDeQuiz.Executado;
    }
}
