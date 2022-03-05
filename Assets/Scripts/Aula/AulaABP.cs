using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AulaABP : Aula
{
    // Após o início da cena/aula, os quizzes serão aplicados depois deste delay
    [SerializeField][Range(0, 30)] float delayParaAplicarQuizzes;
    [SerializeField][Range(0, 30)] float tempoEntreQuizzes;
    [SerializeField][Range(0, 30)] float tempoPosQuizzes;

    [Header("Sprite do Ícone da Metodologia")]
    [SerializeField] Sprite spriteIconeMetodologia;

    [Header("Fim da Aula")]
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
        if (!MetodologiaDaAula.sprite) MetodologiaDaAula.sprite = spriteIconeMetodologia;
    }

    protected override IEnumerator Start()
    {
        yield return base.Start();

        var jogo = EstadoDoJogo.Instance;

        // Obter mídias selecionadas pelo jogador em uma etapa anterior
        MidiasDaAula = ObterMidiasDaAula(jogo);

        // Inicializar UI da aula
        var spriteIconePersonagemSelecionada = EstadoDoJogo.Instance.spriteIconePersonagem;
        if (spriteIconePersonagemSelecionada) iconePersonagemUI.sprite = spriteIconePersonagemSelecionada;

        // Esperar um tempo entre o último quiz e o resultado da aula
        yield return new WaitForSeconds(tempoPosQuizzes);
        StartCoroutine(ApresentarResultadoDaAula());
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

            var categoriasDaMidia = midia.nomeMidia.CategoriasDaMidia();
            bool midiaFoiRepetida = midiasCujasPontuacoesJaForamCalculadas.Contains(midia.nomeMidia);
            pontuacao += MetodologiaDaAula.PontuacaoParaCategoriasDeMidia(categoriasDaMidia, midiaFoiRepetida);

            midiasCujasPontuacoesJaForamCalculadas[i] = midia.nomeMidia;
        }

        // Média aritmética entre as mídias da aula
        return pontuacao / QuantidadeDeMidiasDaAula;
    }

    protected override IEnumerator ApresentarResultadoDaAula()
    {
        yield return null;
    }

    private Midia[] ObterMidiasDaAula(EstadoDoJogo jogo)
    {
        var midiasDaAula = new Midia[QuantidadeDeMidiasDaAula];
        for (int i = 0; i < QuantidadeDeMidiasDaAula; i++)
            midiasDaAula[i] = jogo.MidiasSelecionadas[i];
        return midiasDaAula;
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

