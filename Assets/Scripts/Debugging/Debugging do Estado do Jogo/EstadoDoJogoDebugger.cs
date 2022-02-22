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
        estadoDoJogo.SpriteCorpoPersonagem = SpriteCorpoPersonagem;
        estadoDoJogo.SpriteCabeloPersonagem = SpriteCabeloPersonagem;
        estadoDoJogo.SpriteRoupaPersonagem = SpriteRoupaPersonagem;
        estadoDoJogo.SpriteIconePersonagem = SpriteIconePersonagem;
    }

    public void ReadData()
    {
        EstadoDoJogo estadoDoJogo = EstadoDoJogo.Instance;

        nivelDeEnsinoSelecionado = estadoDoJogo.NivelDeEnsinoSelecionado;
        areaDeConhecimentoSelecionada = estadoDoJogo.AreaDeConhecimentoSelecionada;
        inteligenciasSelecionadas = estadoDoJogo.InteligenciasSelecionadas;
        metodologiaSelecionada = estadoDoJogo.MetodologiaSelecionada;
        midiasSelecionadas = estadoDoJogo.MidiasSelecionadas;
        SpriteCorpoPersonagem = estadoDoJogo.SpriteCorpoPersonagem;
        SpriteCabeloPersonagem = estadoDoJogo.SpriteCabeloPersonagem;
        SpriteRoupaPersonagem = estadoDoJogo.SpriteRoupaPersonagem;
        SpriteIconePersonagem = estadoDoJogo.SpriteIconePersonagem;
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
        estadoDoJogo.SpriteCorpoPersonagem = SpriteCorpoPersonagem;
        estadoDoJogo.SpriteCabeloPersonagem = SpriteCabeloPersonagem;
        estadoDoJogo.SpriteRoupaPersonagem = SpriteRoupaPersonagem;
        estadoDoJogo.SpriteIconePersonagem = SpriteIconePersonagem;
    }
}
