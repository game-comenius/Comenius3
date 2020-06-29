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
}
