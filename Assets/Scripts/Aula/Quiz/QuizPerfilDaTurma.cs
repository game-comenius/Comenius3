using System.Collections;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class QuizPerfilDaTurma : Quiz
{
    [Header("Formato do Quiz")] [SerializeField] FormatoDeQuizVF prefabQuizVF;
    private FormatoDeQuiz formatoDoQuiz;

    // Sprite padrão que será usado para o ícone do quiz, útil quando jogar diretamente a cena da aula
    [SerializeField] Sprite spritePadraoDoIconeDoQuiz;

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
        Sprite spriteDoIconeDoQuiz;

        // Sorteio entre 0 e 1.
        // Se sair 0, o quiz será sobre nível de ensino
        // Se sair 1, o quiz será sobre Inteligências Múltiplas
        //int zeroOuUm = Random.Range(0, 2);
        int zeroOuUm = 1;
        if (zeroOuUm == 0)
        {
            this.NivelDeEnsino = nivelDeEnsino;
            enunciadoDoQuiz = "Analise as afirmativas abaixo e selecione a(s) correta(s) sobre " + nivelDeEnsino.nome;
            spriteDoIconeDoQuiz = nivelDeEnsino.Sprite;
            afirmacoesDisponiveis = AfirmacaoSobreNivelDeEnsino.ObterTodasAsAfirmacoes(nivelDeEnsino);
        }
        else // ZeroOuUm == 1
        {
            this.Inteligencias = inteligencias;
            enunciadoDoQuiz = "Analise as afirmativas abaixo e selecione a(s) correta(s) sobre o par de inteligências " + inteligencias.Nome;
            spriteDoIconeDoQuiz = inteligencias.SpriteGrande;
            afirmacoesDisponiveis = AfirmacaoSobreInteligencias.ObterTodasAsAfirmacoes(inteligencias);
        }

        // Selecionar algumas dessas afirmações para colocar no quiz
        var afirmacoesDoQuiz = new Afirmacao[quantidadeDeAfirmacoesNoQuiz];
        // Selecionar pelo menos uma afirmação verdadeira
        var afirmacoesVerdadeiras = afirmacoesDisponiveis.Where(a => a.Verdadeira);
        var indiceAleatorio = Random.Range(0, afirmacoesVerdadeiras.Count());
        afirmacoesDoQuiz[0] = afirmacoesVerdadeiras.ElementAt(indiceAleatorio);
        // Selecionar as outras afirmações do quiz, que podem ou não serem verdadeiras
        for (int i = 1; i < quantidadeDeAfirmacoesNoQuiz; i++)
        {
            // Remover das afirmações disponíveis as afirmações selecionadas
            afirmacoesDisponiveis = afirmacoesDisponiveis.Except(afirmacoesDoQuiz).ToArray();
            indiceAleatorio = Random.Range(0, afirmacoesDisponiveis.Count());
            var afirmacaoAleatoria = afirmacoesDisponiveis.ElementAt(indiceAleatorio);
            afirmacoesDoQuiz[i] = afirmacaoAleatoria;
        }

        formatoDoQuiz = Instantiate(prefabQuizVF, canvas.transform);
        formatoDoQuiz.TextoDoEnunciado = enunciadoDoQuiz;
        formatoDoQuiz.IconeDoQuiz.sprite = spriteDoIconeDoQuiz ? spriteDoIconeDoQuiz : spritePadraoDoIconeDoQuiz;
        formatoDoQuiz.DefinirAfirmacoes(afirmacoesDoQuiz);
    }

    // Chamar método ConfigurarQuiz antes deste método
    public override IEnumerator Executar()
    {
        estado = EstadoDeQuiz.EmExecucao;

        formatoDoQuiz.Mostrar();

        yield return new WaitUntil(() => formatoDoQuiz.RespostaConfirmada);

        // Mostrar se o jogador acertou ou errou nas suas escolhas
        StartCoroutine(PassarTempoParaAvaliarResposta());
        yield return new WaitUntil(() => formatoDoQuiz.JogadorPediuParaFechar || tempoParaAvaliarRespostaPassou);
        
        formatoDoQuiz.Esconder();

        estado = EstadoDeQuiz.Executado;

        OnQuizzExit.Invoke(TaxaDeAcerto);
    }
}
