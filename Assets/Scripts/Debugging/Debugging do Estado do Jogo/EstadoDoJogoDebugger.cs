using UnityEngine;

public class EstadoDoJogoDebugger : MonoBehaviour
{
    [HideInInspector] public bool updateOnInit;
    [SerializeField] private NivelDeEnsino nivelDeEnsinoSelecionado;
    [SerializeField] private AreaDeConhecimento areaDeConhecimentoSelecionada;
    [SerializeField] private Inteligencias inteligenciasSelecionadas;
    [SerializeField] private Metodologia metodologiaSelecionada;
    [SerializeField] private Midia[] midiasSelecionadas;
    [SerializeField] private Sprite SpriteCorpoPersonagem;
    [SerializeField] private Sprite SpriteCabeloPersonagem;
    [SerializeField] private Sprite SpriteRoupaPersonagem;
    [SerializeField] private Sprite SpriteIconePersonagem;

    public void OnEnable()
    {
        if (updateOnInit)
            DefaultInitialization();
        else
            ReadData();
    }

    public void WriteData()
    {
        EstadoDoJogo estadoDoJogo = EstadoDoJogo.Instance;

        estadoDoJogo.NivelDeEnsinoSelecionado = nivelDeEnsinoSelecionado;
        estadoDoJogo.AreaDeConhecimentoSelecionada = areaDeConhecimentoSelecionada;
        estadoDoJogo.InteligenciasSelecionadas = inteligenciasSelecionadas;
        estadoDoJogo.MetodologiaSelecionada = metodologiaSelecionada;
        estadoDoJogo.MidiasSelecionadas = midiasSelecionadas;
        estadoDoJogo.spriteCorpoPersonagem = SpriteCorpoPersonagem;
        estadoDoJogo.spriteCabeloPersonagem = SpriteCabeloPersonagem;
        estadoDoJogo.spriteRoupaPersonagem = SpriteRoupaPersonagem;
        estadoDoJogo.spriteIconePersonagem = SpriteIconePersonagem;
    }

    public void ReadData()
    {
        EstadoDoJogo estadoDoJogo = EstadoDoJogo.Instance;

        nivelDeEnsinoSelecionado = estadoDoJogo.NivelDeEnsinoSelecionado;
        areaDeConhecimentoSelecionada = estadoDoJogo.AreaDeConhecimentoSelecionada;
        inteligenciasSelecionadas = estadoDoJogo.InteligenciasSelecionadas;
        metodologiaSelecionada = estadoDoJogo.MetodologiaSelecionada;
        midiasSelecionadas = estadoDoJogo.MidiasSelecionadas;
        SpriteCorpoPersonagem = estadoDoJogo.spriteCorpoPersonagem;
        SpriteCabeloPersonagem = estadoDoJogo.spriteCabeloPersonagem;
        SpriteRoupaPersonagem = estadoDoJogo.spriteRoupaPersonagem;
        SpriteIconePersonagem = estadoDoJogo.spriteIconePersonagem;
    }

    public void DefaultInitialization()
    {
        EstadoDoJogo estadoDoJogo = EstadoDoJogo.Instance;

        Midia[] midias = new Midia[4];

        midias[0] = new Midia(NomeDeMidia.AVEAs);
        midias[1] = new Midia(NomeDeMidia.CadernosECartazes);
        midias[2] = new Midia(NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas);
        midias[3] = new Midia(NomeDeMidia.Lousa);

        estadoDoJogo.NivelDeEnsinoSelecionado = NivelDeEnsino.EducacaoInfantil;
        estadoDoJogo.AreaDeConhecimentoSelecionada = AreaDeConhecimento.CienciasBiologicas;
        estadoDoJogo.InteligenciasSelecionadas = Inteligencias.CorporalCinestesicaComNaturalista;
        estadoDoJogo.MetodologiaSelecionada = Metodologia.Invertida;
        estadoDoJogo.MidiasSelecionadas = midias;
        estadoDoJogo.spriteCorpoPersonagem = SpriteCorpoPersonagem;
        estadoDoJogo.spriteCabeloPersonagem = SpriteCabeloPersonagem;
        estadoDoJogo.spriteRoupaPersonagem = SpriteRoupaPersonagem;
        estadoDoJogo.spriteIconePersonagem = SpriteIconePersonagem;
    }
}
