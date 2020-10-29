using System.Collections;
using System.Linq;
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

    [Header("Sprite do Ícone da Metodologia")]
    [SerializeField] Sprite spriteIconeMetodologia;

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


    private void Awake()
    {
        // Definir qual é a metodologia desta aula
        MetodologiaDaAula = Metodologia.ABP;
        if (!MetodologiaDaAula.Sprite) MetodologiaDaAula.Sprite = spriteIconeMetodologia;

        // Ordenar os quizzes
        Quiz[] localQuizzes =
        {
            quizDeMidia1,
            quizDeMidia2,
            quizMetodologiaABP,
            quizPerfilDaTurma
        };
        Quizzes = localQuizzes;
    }

    protected override IEnumerator Start()
    {
        yield return base.Start();

        var jogo = EstadoDoJogo.Instance;

        // Obter mídias selecionadas pelo jogador em uma etapa anterior
        MidiasDaAula = ObterMidiasDaAula(jogo);

        // A primeira mídia será mostrada logo no início, antes de qualquer quiz.
        // Já a segunda mídia será mostrada na metade dos quizzes
        ConfigurarTrocaDeMidiasDuranteAula(MidiasDaAula);

        // Inicializar UI da aula
        var spriteIconePersonagemSelecionada = EstadoDoJogo.Instance.SpriteIconePersonagem;
        if (spriteIconePersonagemSelecionada) iconePersonagemUI.sprite = spriteIconePersonagemSelecionada;

        // Configurar e aplicar os quizzes na aula
        ConfigurarQuizzes();
        yield return StartCoroutine(AplicarQuizzes(Quizzes, delayParaAplicarQuizzes, tempoEntreQuizzes));

        // Esperar um tempo entre o último quiz e o resultado da aula
        yield return new WaitForSeconds(tempoPosQuizzes);
        StartCoroutine(ApresentarResultadoDaAula());
    }

    private void ConfigurarQuizzes()
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

    // Obtém a pontuação da aula de uma vez só, um float apenas.
    // Observação: Se for necessário, quebrar essa função em mais funções, uma
    // para cada mídia escolhida para esta metodologia.
    public override float ObterPontuacaoDaAula()
    {
        float pontuacao = 0;

        if (MidiasDaAula == null) MidiasDaAula = ObterMidiasDaAula(EstadoDoJogo.Instance);

        var midiasCujasPontuacoesJaForamCalculadas = new NomeDeMidia[QuantidadeDeMidiasDaAula];

        for (int i = 0; i < QuantidadeDeMidiasDaAula; i++)
        {
            var midia = MidiasDaAula[i];

            var categoriasDaMidia = midia.NomeMidia.CategoriasDaMidia();
            bool midiaFoiRepetida = midiasCujasPontuacoesJaForamCalculadas.Contains(midia.NomeMidia);
            pontuacao += MetodologiaDaAula.PontuacaoParaCategoriasDeMidia(categoriasDaMidia, midiaFoiRepetida);

            midiasCujasPontuacoesJaForamCalculadas[i] = midia.NomeMidia;
        }

        // Média aritmética entre as mídias da aula
        return pontuacao / QuantidadeDeMidiasDaAula;
    }

    protected override IEnumerator ApresentarResultadoDaAula()
    {
        paginaResultadoDaAula.Mostrar();
        paginaResultadoDaAula.Atualizar(ObterPontuacaoDaAula(), Quizzes);

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

    private void ConfigurarTrocaDeMidiasDuranteAula(Midia[] midias)
    {
        // Mostrar a primeira mídia logo no início com um pequeno delay
        var delayParaTroca = delayParaAplicarQuizzes / 3;
        StartCoroutine(TrocarDeMidiaNaSala(midias[0].NomeMidia, delayParaTroca, 0));

        // Na aula ABP, serão 2 mídias, o jogo irá trocar a mídia mais ou menos no meio da aula
        // O meio da aula é na metade dos quizzes
        var quantidadeDeQuizzesDaAula = Quizzes.Length;
        var quizzesExecutados = 0;
        this.UmQuizFoiAplicadoComSucessoEvent += (quiz) =>
        {
            quizzesExecutados++;
            if (quizzesExecutados == Mathf.Ceil(quantidadeDeQuizzesDaAula / 2.0f))
            {
                var intervaloDeTempo = tempoEntreQuizzes / 3;
                StartCoroutine(TrocarDeMidiaNaSala(midias[1].NomeMidia, intervaloDeTempo, intervaloDeTempo));
            }
        };
    }

    private IEnumerator TrocarDeMidiaNaSala(NomeDeMidia midiaQueSeraUsada, float delayParaTroca, float tempoDaTroca)
    {
        yield return new WaitForSeconds(delayParaTroca);
        SalaDeAulaEscolhida.MidiasNaSalaDeAula.EsconderMidiasNaSalaDeAula();
        yield return new WaitForSeconds(tempoDaTroca);
        SalaDeAulaEscolhida.MidiasNaSalaDeAula.MostrarMidiasNaSalaDeAula(midiaQueSeraUsada);
    }

    private void TerminarAula()
    {
        trocadorDeCenaCreditos.TrocarCena();
    }

    
}

