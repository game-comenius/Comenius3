using UnityEngine;

public class EstadoDoJogo : Singleton<EstadoDoJogo>
{
    // Propriedades definidas pelo criador de um jogo
    private NivelDeEnsino nivelDeEnsinoSelecionado;
    public NivelDeEnsino NivelDeEnsinoSelecionado
    {
        get
        {
            if (nivelDeEnsinoSelecionado == null)
                nivelDeEnsinoSelecionado = NivelDeEnsino.EnsinoSuperior;
            return nivelDeEnsinoSelecionado;
        }

        set => nivelDeEnsinoSelecionado = value;
    }

    private AreaDeConhecimento areaDeConhecimentoSelecionada;
    public AreaDeConhecimento AreaDeConhecimentoSelecionada
    {
        get
        {
            if (areaDeConhecimentoSelecionada == null)
                areaDeConhecimentoSelecionada = AreaDeConhecimento.CienciasHumanas;
            return areaDeConhecimentoSelecionada;
        }

        set => areaDeConhecimentoSelecionada = value;
    }

    private Inteligencias inteligenciasSelecionadas;
    public Inteligencias InteligenciasSelecionadas
    {
        get
        {
            if (inteligenciasSelecionadas == null)
                inteligenciasSelecionadas = Inteligencias.LinguisticaComLogicoMatematica;
            return inteligenciasSelecionadas;
        }

        set => inteligenciasSelecionadas = value;
    }

    private Metodologia metodologiaSelecionada;
    public Metodologia MetodologiaSelecionada
    {
        get
        {
            if (metodologiaSelecionada == null)
                metodologiaSelecionada = Metodologia.ABP;
            return metodologiaSelecionada;
        }

        set => metodologiaSelecionada = value;
    }

    // Características da personagem selecionada, observar se estes valores != null
    public Sprite SpriteCorpoPersonagem { get; set; }
    public Sprite SpriteCabeloPersonagem { get; set; }
    public Sprite SpriteRoupaPersonagem { get; set; }
    public Sprite SpriteIconePersonagem { get; set; }
}
