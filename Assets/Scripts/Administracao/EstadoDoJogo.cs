using System.Collections;
using System.Collections.Generic;
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
                nivelDeEnsinoSelecionado = NivelDeEnsino.EnsinoFundamental;
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
                areaDeConhecimentoSelecionada = AreaDeConhecimento.Historia;
            return areaDeConhecimentoSelecionada;
        }

        set => areaDeConhecimentoSelecionada = value;
    }
}
