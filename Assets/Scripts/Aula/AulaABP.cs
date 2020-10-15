using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AulaABP : Aula
{
    [Header("Quizzes")]
    [SerializeField] QuizDeMidia quizDeMidia1;
    [SerializeField] QuizDeMidia quizDeMidia2;
    [SerializeField] QuizMetodologiaABP quizMetodologiaABP;
    [SerializeField] QuizPerfilDaTurma quizPerfilDaTurma;
    // Após o início da cena/aula, os quizzes serão aplicados depois deste delay
    [SerializeField] [Range(0, 30)] float delayParaAplicarQuizzes;
    [SerializeField] [Range(0, 30)] float tempoEntreQuizzes;
    [SerializeField] [Range(0, 30)] float tempoPosQuizzes;
    private Quiz[] quizzes;

    [Header("Fim da Aula")]
    [SerializeField] PaginaResultadoDaAula paginaResultadoDaAula;
    [SerializeField] TrocadorDeCena trocadorDeCenaCreditos;

    [Header("Alunos")]
    public GameObject AlunosJovens;
    public GameObject AlunosCriancas;

    [Header("UI Aula")]
    [SerializeField] Image iconePersonagemUI;

    // Na aula com metodologia ABP, o jogador escolhe 2 mídias
    // As 2 primeiras mídias no array de mídias selecionadas serão
    // consideradas as mídias escolhidas pelo jogador para essa metodologia
    public int QuantidadeDeMidiasDaAula { get; set; } = 2;
    public Midia[] MidiasDaAula { get; set; }


    protected override IEnumerator Start()
    {
        yield return base.Start();

        // Definir qual é a metodologia desta aula
        MetodologiaDaAula = Metodologia.ABP;

        var jogo = EstadoDoJogo.Instance;

        // Obter mídias selecionadas pelo jogador em uma etapa anterior
        MidiasDaAula = ObterMidiasDaAula(jogo);

        // Inicializar UI da aula
        var spriteIconePersonagemSelecionada = EstadoDoJogo.Instance.SpriteIconePersonagem;
        if (spriteIconePersonagemSelecionada) iconePersonagemUI.sprite = spriteIconePersonagemSelecionada;

        var quizzes = ObterQuizzesConfigurados();
        yield return StartCoroutine(AplicarQuizzes(quizzes, delayParaAplicarQuizzes, tempoEntreQuizzes));

        // Esperar um tempo entre o último quiz e o resultado da aula
        yield return new WaitForSeconds(tempoPosQuizzes);
        StartCoroutine(ApresentarResultadoDaAula());
    }

    private Quiz[] ObterQuizzesConfigurados()
    {
        var jogo = EstadoDoJogo.Instance;

        // O primeiro quiz será um quiz de mídia sobre aquela que jogador escolheu primeiro
        quizDeMidia1.ConfigurarQuiz(MidiasDaAula[0]);
        // O segundo quiz será um quiz de mídia sobre aquela que o jogador escolheu por segundo
        quizDeMidia2.ConfigurarQuiz(MidiasDaAula[1]);
        // O terceiro quiz será um quiz sobre a metodologia escolhida e não precisa ser configurado
        // ...
        // O quarto quiz será sobre o perfil da turma definido no início do jogo
        var nivelDeEnsino = jogo.NivelDeEnsinoSelecionado;
        var inteligencias = jogo.InteligenciasSelecionadas;
        quizPerfilDaTurma.ConfigurarQuiz(nivelDeEnsino, inteligencias);

        // Ordenar os quizzes
        Quiz[] localQuizzes =
        {
            quizDeMidia1,
            quizDeMidia2,
            quizMetodologiaABP,
            quizPerfilDaTurma
        };
        return quizzes = localQuizzes;
    }

    private IEnumerator AplicarQuizzes(Quiz[] quizzes, float delayParaComecar, float tempoEntreQuizzes)
    {
        yield return new WaitForSeconds(delayParaComecar);

        for (int i = 0; i < quizzes.Length; i++)
        {
            // Executar quiz e esperar o jogador responder ele completamente
            yield return StartCoroutine(AplicarQuiz(quizzes[i]));
            // Aplicar tempo entre os quizzes (if para evitar espera após último quiz)
            if (i < quizzes.Length - 1) yield return new WaitForSeconds(tempoEntreQuizzes);
        }
    }

    protected override IEnumerator AplicarQuiz(Quiz quiz)
    {
        yield return StartCoroutine(quiz.Executar());
    }

    // Obtém a pontuação da aula de uma vez só, um float apenas.
    // Observação: Se for necessário, quebrar essa função em mais funções, uma
    // para cada mídia escolhida para esta metodologia.
    public override float ObterPontuacaoDaAula()
    {
        float pontuacao = 0;

        if (MidiasDaAula == null) ObterMidiasDaAula(EstadoDoJogo.Instance);

        foreach (var midia in MidiasDaAula)
        {
            var categoriasDaMidia = midia.NomeMidia.CategoriasDaMidia();
            pontuacao += MetodologiaDaAula.PontuacaoParaCategoriasDeMidia(categoriasDaMidia);
        }

        // Média aritmética entre as mídias da aula
        return pontuacao / QuantidadeDeMidiasDaAula;
    }

    protected override IEnumerator ApresentarResultadoDaAula()
    {
        paginaResultadoDaAula.Mostrar();
        paginaResultadoDaAula.Atualizar(ObterPontuacaoDaAula(), quizzes);

        yield return new WaitWhile(() => paginaResultadoDaAula.EmUso);

        TerminarAula();
    }

    private Midia[] ObterMidiasDaAula(EstadoDoJogo jogo)
    {
        var midiasDaAula = new Midia[QuantidadeDeMidiasDaAula];
        for (int i = 0; i < QuantidadeDeMidiasDaAula; i++)
            midiasDaAula[i] = jogo.MidiasSelecionadas[i];
        return midiasDaAula;
    }

    private void TerminarAula()
    {
        trocadorDeCenaCreditos.TrocarCena();
    }

    
}

