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

        estadoDoJogo.NivelDeEnsino = nivelDeEnsinoSelecionado;
        estadoDoJogo.AreaDeConhecimento = areaDeConhecimentoSelecionada;
        estadoDoJogo.Inteligencias = inteligenciasSelecionadas;
        estadoDoJogo.Metodologia = metodologiaSelecionada;
        estadoDoJogo.Midias = midiasSelecionadas;
        estadoDoJogo.SpriteCorpoPersonagem = SpriteCorpoPersonagem;
        estadoDoJogo.SpriteCabeloPersonagem = SpriteCabeloPersonagem;
        estadoDoJogo.SpriteRoupaPersonagem = SpriteRoupaPersonagem;
        estadoDoJogo.SpriteIconePersonagem = SpriteIconePersonagem;
    }

    public void ReadData()
    {
        EstadoDoJogo estadoDoJogo = EstadoDoJogo.Instance;

        nivelDeEnsinoSelecionado = estadoDoJogo.NivelDeEnsino;
        areaDeConhecimentoSelecionada = estadoDoJogo.AreaDeConhecimento;
        inteligenciasSelecionadas = estadoDoJogo.Inteligencias;
        metodologiaSelecionada = estadoDoJogo.Metodologia;
        midiasSelecionadas = estadoDoJogo.Midias;
        SpriteCorpoPersonagem = estadoDoJogo.SpriteCorpoPersonagem;
        SpriteCabeloPersonagem = estadoDoJogo.SpriteCabeloPersonagem;
        SpriteRoupaPersonagem = estadoDoJogo.SpriteRoupaPersonagem;
        SpriteIconePersonagem = estadoDoJogo.SpriteIconePersonagem;
    }

    public void DefaultInitialization()
    {
        EstadoDoJogo estadoDoJogo = EstadoDoJogo.Instance;

        Midia[] midias = new Midia[4];

        midias[0] = new Midia(NomeDeMidia.Plataformas);
        midias[1] = new Midia(NomeDeMidia.CadernosECartazes);
        midias[2] = new Midia(NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas);
        midias[3] = new Midia(NomeDeMidia.Lousa);

        estadoDoJogo.NivelDeEnsino = NivelDeEnsino.EducacaoInfantil;
        estadoDoJogo.AreaDeConhecimento = AreaDeConhecimento.CienciasBiologicas;
        estadoDoJogo.Inteligencias = Inteligencias.CorporalCinestesicaComNaturalista;
        estadoDoJogo.Metodologia = Metodologia.SAI;
        estadoDoJogo.Midias = midias;
        estadoDoJogo.SpriteCorpoPersonagem = SpriteCorpoPersonagem;
        estadoDoJogo.SpriteCabeloPersonagem = SpriteCabeloPersonagem;
        estadoDoJogo.SpriteRoupaPersonagem = SpriteRoupaPersonagem;
        estadoDoJogo.SpriteIconePersonagem = SpriteIconePersonagem;
    }
}
